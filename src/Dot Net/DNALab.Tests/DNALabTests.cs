namespace DNALab.Tests
{
    using Shouldly;
    using Xunit;

    public class DNALabTests
    {
        public readonly DNALab _sut;

        public DNALabTests()
        {
            _sut = new DNALab();
        }

        [Fact]
        public void Text_ShouldBeNull()
        {
            _sut.Text.ShouldNotBeNull();
        }
    }
}
