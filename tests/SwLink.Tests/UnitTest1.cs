using SwLint.Core.Token;

/* 

How to run unit tests:

```powershell
cd sw-lint
dotnet test # in the repo root
PS C:\Users\Ashton Dudley\DalFSAE\sw-lint> dotnet test
  Determining projects to restore...
  All projects are up-to-date for restore.
  SwLint.Core -> C:\Users\Ashton Dudley\DalFSAE\sw-lint\src\SwLint.Core\bin\Debug\net8.0\SwLint.Core.dll
  SwLint.Tests -> C:\Users\Ashton Dudley\DalFSAE\sw-lint\tests\SwLink.Tests\bin\Debug\net8.0\SwLint.Tests.dll
Test run for C:\Users\Ashton Dudley\DalFSAE\sw-lint\tests\SwLink.Tests\bin\Debug\net8.0\SwLint.Tests.dll (.NETCoreApp,Version=v8.0)
Microsoft (R) Test Execution Command Line Tool Version 17.9.0 (x64)
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
A total of 1 test files matched the specified pattern.
...
```

 */



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