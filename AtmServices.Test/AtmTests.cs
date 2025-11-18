namespace AtmServices.Test;
using AtmServices;

public class AtmTests
{
    Atm testAtm;
    int initialBalance = 100;

    public AtmTests() {
        testAtm = new Atm(initialBalance);
    } 

    [Fact]
    public void Test_Withdraw()
    {
        var result = testAtm.withdraw(25); // new balance 75
        var result_false = testAtm.withdraw(76);
        
        Assert.True(result);
        Assert.False(result_false);
        Assert.Equal(75, testAtm.getBalance());
    }
    
    [Fact]
    public void Test_Deposit()
    {
        var result = testAtm.deposit(25);
        var result_false = testAtm.deposit(-25);


        Assert.True(result);
        Assert.False(result_false);
        Assert.Equal(125, testAtm.getBalance());
    }
}