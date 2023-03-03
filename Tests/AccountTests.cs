using Models; 
using Services;

namespace Tests;

/*Run these to see test coverage*/
/* dotnet test --collect:"XPlat Code Coverage" */
/* reportgenerator -reports:"./TestResults/{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html */

public class AccountTests{
    [Fact]
    public void AccountShouldCreate(){
        Account acct = new();
        acct.workerType = 'M';
        acct.workId = 22;
        acct.password = "Yayasdd";
        Assert.NotNull(acct);
        Assert.False(acct.workId == 0);
        Assert.False(string.IsNullOrEmpty(acct.password));
    }
}