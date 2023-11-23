namespace DNALab.Text.Encoding
{
    using Concurrent;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    ///     The ITextEncoderDecoder interface.
    /// </summary>
    public interface ITextEncoderDecoder :
        global::DNALab.IDecoder<string, string>,
        global::DNALab.IEncoder<string, string>,
        IDecoder<string, string>,
        IEncoder<string, string>
    {
        /// <summary>
        ///     Decodes the specified value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="encoding">The text <see cref="Encoding" /> encoding (ex. ASCII, UTF8, etc).</param>
        /// <returns>The string value of DNA sequence.</returns>
        string Decode(string value, Encoding encoding);

        /// <summary>
        ///     Encodes the specified DNA sequence.
        /// </summary>
        /// <param name="dnaSequence">The DNA sequence.</param>
        /// <param name="encoding">The text <see cref="Encoding" /> encoding (ex. ASCII, UTF8, etc).</param>
        /// <returns>The string value of encoded DNA sequence.</returns>
        string Encode(string dnaSequence, Encoding encoding);

        /// <summary>
        ///     Decodes the specified value asynchronously.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="encoding">The text <see cref="Encoding" /> encoding (ex. ASCII, UTF8, etc).</param>
        /// <returns>The task result of string value of DNA sequence.</returns>
        Task<string> DecodeAsync(string value, Encoding encoding);

        /// <summary>
        ///     Encodes the specified DNA sequence asynchronously.
        /// </summary>
        /// <param name="dnaSequence">The DNA sequence.</param>
        /// <param name="encoding">The text <see cref="Encoding" /> encoding (ex. ASCII, UTF8, etc).</param>
        /// <returns>The task result of string value of encoded DNA sequence.</returns>
        Task<string> EncodeAsync(string dnaSequence, Encoding encoding);
    }
}