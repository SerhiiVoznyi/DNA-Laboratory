using DNALab.Core;

namespace DNALab.Tests.Helpers
{
    using Shouldly;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;

    public class StringHelper_Should
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(1, 0, 0)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 1, 2)]
        [InlineData(2, 2, 1)]
        [InlineData(2, 3, 1)]
        [InlineData(5, 3, 2)]
        public void Split_ByChunks(int stringLength, int chunkSize, int expectedSize)
        {
            var value = new string('A', stringLength);
            value.SplitToChunks(chunkSize).ToList().Count.ShouldBe(expectedSize);
        }

        [Theory]
        [MemberData(nameof(DNAMapSequences))]
        public void IsDNASequence_Return_True_For_DNAMapSequences_Keys(string value)
        {
            value.IsDNASequence().ShouldBeTrue();
        }

        public static IEnumerable<object[]> DNAMapSequences =>
            Constants.DnaCodeToByteMap.Select(s => new object[] { s.Key });


        [Theory]
        [MemberData(nameof(DNAMapSequences))]
        public void IsDNASequence_Return_True_For_ByteMapSequences_Value(string value)
        {
            value.IsDNASequence().ShouldBeTrue();
        }

        public static IEnumerable<object[]> ByteMapSequences =>
            Constants.ByteToDnaCodeMap.Select(s => new object[] { s.Value });

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("Some dummy text")]
        [InlineData("A")]
        [InlineData("AA")]
        [InlineData("AAA")]
        [InlineData("G")]
        [InlineData("GG")]
        [InlineData("GGG")]
        [InlineData("C")]
        [InlineData("CC")]
        [InlineData("CCC")]
        [InlineData("T")]
        [InlineData("TT")]
        [InlineData("TTT")]
        [InlineData("AGCTA")]
        [InlineData("AGCTC")]
        [InlineData("AGCTG")]
        [InlineData("AGCTT")]
        public void Return_False_If_Not_DNASequence(string value)
        {
            value.IsDNASequence().ShouldBeFalse();
        }

        [Fact]
        public void IsDNASequence_Return_True()
        {
            string.Concat(Constants.ByteToDnaCodeMap.Select(s => s.Value)).IsDNASequence().ShouldBeTrue();
        }
    }
}