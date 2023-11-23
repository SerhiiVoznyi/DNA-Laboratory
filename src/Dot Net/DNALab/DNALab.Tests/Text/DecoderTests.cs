namespace DNALab.Tests.Text
{
    using System.Text;
    using global::DNALab.Core;
    using global::DNALab.Text.Encoding;
    using Shouldly;
    using Xunit;

    public class Decoder_Should
    {
        public Decoder_Should()
        {
            _sut = new TextEncoderDecoder();
        }

        private readonly ITextEncoderDecoder _sut;

        [Theory]
        [InlineData("", "")]
        [InlineData("CAGACGCCCGTACGTACGTTAGAACTCTCGTTCTAGCGTACGCAAGTG", "Hello world.")]
        [InlineData("TCAAGCCTTCAAGTCATCACGAAATCAAGTAATCAAGTAGTCACGAACTCACGAAGTCAAGTAGTCACGAATTCAAGTGCAGTG",
            "Здравствуй.")]
        public void Convert_DNASequence_To_Text(string input, string expected)
        {
            _sut.Decode(input, Encoding.UTF8).ShouldBe(expected);
        }

        [Fact]
        public void Throw_InvalidDNASequenceException()
        {
            Should.Throw<InvalidDNASequenceException>(() => _sut.Decode("Invalid DNA Sequence"));
        }
    }
}