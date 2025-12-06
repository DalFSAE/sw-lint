using SwLint.Core.Token;



namespace SwLink.Tests;
public class UnitTest1
{
    public class DmsFileNameTokenizerTests
    {
        [Fact]
        public void Valid_FileName_Should_Parse()
        {
            var token = DmsFileNameTokenizer.Parse("DMS-27-CH-FRAME-P-000-MOUNT.SLDPRT");

            Assert.True(token.IsValid);
            Assert.Equal("DMS", token.Prefix);
            Assert.Equal("27", token.Year);
            Assert.Equal("CH", token.System);
            Assert.Equal("FRAME", token.Project);
            Assert.Equal("P", token.Type);
            Assert.Equal("000", token.ID);
            Assert.Equal("MOUNT", token.Comment);
        }

        [Fact]
        public void Invalid_FileName_Should_Fail()
        {
            var token = DmsFileNameTokenizer.Parse("BAD-NAME.SLDPRT");

            Assert.False(token.IsValid);
        }
    }
}