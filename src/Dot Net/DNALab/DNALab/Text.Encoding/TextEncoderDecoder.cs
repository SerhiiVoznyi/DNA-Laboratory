namespace DNALab.Text.Encoding
{
    using Core;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TextEncoderDecoder : ITextEncoderDecoder
    {
        /// <summary>
        ///     Decodes the specified value with default [ASCII] <see cref="Encoding" />.
        /// </summary>
        /// <param name="value">The value.</param>
        public string Decode(string value)
        {
            return Decode(value, Encoding.ASCII);
        }

        public string Decode(string value, Encoding encoding)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;

            if (!value.IsDNASequence()) throw new InvalidDNASequenceException();

            var dnaChunks = value.SplitToChunks(Constants.NucleotidesLength);
            var bytes = dnaChunks.Select(s => Constants.DnaCodeToByteMap[s]);

            return encoding.GetString(bytes.ToArray());
        }

        /// <summary>
        ///     Decodes the specified value with default [ASCII] <see cref="Encoding" /> asynchronously.
        /// </summary>
        /// <param name="value">The value.</param>
        public Task<string> DecodeAsync(string value)
        {
            return DecodeAsync(value, Encoding.ASCII);
        }

        public async Task<string> DecodeAsync(string value, Encoding encoding)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;

            if (!value.IsDNASequence()) throw new InvalidDNASequenceException();

            var decodingTasks = value
                .SplitToChunks(Constants.NucleotidesLength)
                .Select(s => Task.Run(() => Constants.DnaCodeToByteMap[s]))
                .ToList();

            await Task.WhenAll(decodingTasks).ConfigureAwait(false);

            return encoding.GetString(decodingTasks.Select(s => s.Result).ToArray());
        }

        /// <summary>
        ///     Encodes the specified value with default [ASCII] <see cref="Encoding" />.
        /// </summary>
        /// <param name="value">The value.</param>
        public string Encode(string value)
        {
            return Encode(value, Encoding.ASCII);
        }

        public string Encode(string dnaSequence, Encoding encoding)
        {
            var stringBuilder = new StringBuilder();

            foreach (var b in encoding.GetBytes(dnaSequence))
                stringBuilder.Append(Constants.ByteToDnaCodeMap[b]);

            return stringBuilder.ToString();
        }

        /// <summary>
        ///     Encodes the specified value with default [ASCII] <see cref="Encoding" /> asynchronously.
        /// </summary>
        /// <param name="value">The value.</param>
        public Task<string> EncodeAsync(string value)
        {
            return EncodeAsync(value, Encoding.ASCII);
        }

        public async Task<string> EncodeAsync(string dnaSequence, Encoding encoding)
        {
            var encodingTasks = encoding
                .GetBytes(dnaSequence)
                .Select(s => Task.Run(() => Constants.ByteToDnaCodeMap[s]))
                .ToArray();

            await Task.WhenAll(encodingTasks).ConfigureAwait(false);

            return string.Concat(encodingTasks.Select(s => s.Result));
        }
    }
}