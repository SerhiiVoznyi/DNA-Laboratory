namespace DNALab.Tests.Core
{
    using System.Linq;
    using global::DNALab.Core;
    using Shouldly;
    using Xunit;

    public class ByteMapTests
    {
        [Fact]
        public void ByteToDna_Should_Map_AllBytes()
        {
            // Arrange
            var byteToDna = Constants.ByteToDnaCodeMap;
            var dnaToByte = Constants.DnaCodeToByteMap;

            // Assert
            byteToDna.Count.ShouldBe(byte.MaxValue);
            dnaToByte.Count.ShouldBe(byte.MaxValue);
            byteToDna.All(s => dnaToByte.ContainsKey(s.Value)).ShouldBeTrue();
            dnaToByte.All(s => byteToDna.ContainsKey(s.Value)).ShouldBeTrue();
        }
    }
}