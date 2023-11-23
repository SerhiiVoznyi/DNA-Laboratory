namespace DNALab.Tests.Text
{
    using System.Text;
    using System.Threading.Tasks;
    using global::DNALab.Text.Encoding;
    using Shouldly;
    using Xunit;

    public class Encoder_Should
    {
        private readonly TextEncoderDecoder _sut;

        public Encoder_Should()
        {
            _sut = new TextEncoderDecoder();
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("Hello world.", "CAGACGCCCGTACGTACGTTAGAACTCTCGTTCTAGCGTACGCAAGTG")]
        [InlineData("Здравствуй.",
            "TCAAGCCTTCAAGTCATCACGAAATCAAGTAATCAAGTAGTCACGAACTCACGAAGTCAAGTAGTCACGAATTCAAGTGCAGTG")]
        public void Encode_Text_To_DNASequence(string input, string expected)
        {
            _sut.Encode(input, Encoding.UTF8).ShouldBe(expected);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("Hello world.", "CAGACGCCCGTACGTACGTTAGAACTCTCGTTCTAGCGTACGCAAGTG")]
        [InlineData("Здравствуй.",
            "TCAAGCCTTCAAGTCATCACGAAATCAAGTAATCAAGTAGTCACGAACTCACGAAGTCAAGTAGTCACGAATTCAAGTGCAGTG")]
        public async Task EncodeAsync_Text_To_DNASequence(string input, string expected)
        {
            var result = await _sut.EncodeAsync(input, Encoding.UTF8);
            result.ShouldBe(expected);
        }
    }
}