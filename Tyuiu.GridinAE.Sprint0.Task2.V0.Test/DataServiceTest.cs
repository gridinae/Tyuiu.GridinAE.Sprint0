namespace Tyuiu.GridinAE.Sprint0.Task2.V0.Test;

using Tyuiu.GridinAE.Sprint0.Task2.V0.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckGetMessageValid()
    {
        var name = "Игорь";
        var res = DataService.GetMessage(name);

        Assert.AreEqual("Привет..., Игорь", res);
    }
}