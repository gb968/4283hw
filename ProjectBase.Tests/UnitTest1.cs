using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectBase;
namespace ProjectBase.Tests;

[TestClass]
public class UnitTests
{
    [DataRow(18.4,Category.Underweight)]
    [DataRow(18.5,Category.Normalweight)]
    [DataRow(18.6,Category.Normalweight)]
    [DataRow(24.9,Category.Normalweight)]
    [DataRow(25,Category.Overweight)]
    [DataRow(25.1,Category.Overweight)]
    [DataRow(29.9,Category.Overweight)]
    [DataRow(30,Category.Obese)]
    [DataRow(30.1,Category.Obese)]
    [DataTestMethod]
    public void CategorySorter_Test(double input,Category expected)
    {
        var functions = new Functions();
        var output = functions.CategorySorter(input);
        Assert.AreEqual(expected,output);
    }
    [DataRow(5,3,125,22.7)]
    [DataTestMethod]
    public void bmiCalculator_Test(int feet, int inches, int pounds, double expected){
        var functions = new Functions();
        var output = functions.bmiCalculator(feet,inches,pounds);
        Assert.AreEqual(expected,output);
    }
}