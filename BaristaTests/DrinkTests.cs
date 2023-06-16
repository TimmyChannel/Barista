using Barista.Model;
namespace Lab11Tests;

[TestClass]
public class DrinkTests
{
    Drink coffee;
    Drink chocolate;
    Drink cocoa;
    Additive sugar;
     [TestInitialize]
     public void Init()
     {
        coffee=new BaseCoffee();
        chocolate=new BaseChocolate();
        cocoa=new BaseCocoa();
      
     }
    [TestMethod]
    public void CoffeeGetCostTest()
    {
    double expected=205;
    double actual=coffee.GetCost();
     Assert.AreEqual(expected,actual);
    }
     [TestMethod]
    public void CocoaGetCostTest()
    {
    double expected=240;
    double actual=cocoa.GetCost();
     Assert.AreEqual(expected,actual);
    }
     [TestMethod]
    public void ChocolateGetCostTest()
    {
    double expected=260;
    double actual=chocolate.GetCost();
     Assert.AreEqual(expected,actual);
    }
  [TestMethod]
    public void AdditingSugarToCoffeeGetCostTest()
    {
    Drink coffeeWithoneSpoonOfSugar=new AdditiveSugar(coffee);
    double expected=215;
    double actual=coffeeWithoneSpoonOfSugar.GetCost();
     Assert.AreEqual(expected,actual);
    }
 [TestMethod]
    public void AdditingCreamToCoffeeGetCostTest()
    {
    Drink coffeeWithCream=new AdditiveCream(coffee);
    double expected=245;
    double actual=coffeeWithCream.GetCost();
     Assert.AreEqual(expected,actual);
    }

 [TestMethod]
    public void AdditingMilkToCoffeeGetCostTest()
    {
    Drink coffeeWithMilk=new AdditiveMilk(coffee);
    double expected=230;
    double actual=coffeeWithMilk.GetCost();
     Assert.AreEqual(expected,actual);
    }
 [TestMethod]
    public void AdditingSugarToCocoaGetCostTest()
    {
    Drink cocoaWithoneSpoonOfSugar=new AdditiveSugar(cocoa);
    double expected=250;
    double actual=cocoaWithoneSpoonOfSugar.GetCost();
     Assert.AreEqual(expected,actual);
    }
 [TestMethod]
    public void AdditingMilkToCocoaGetCostTest()
    {
    Drink cocoawithMilk=new AdditiveMilk(cocoa);
    double expected=265;
    double actual=cocoawithMilk.GetCost();
     Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void AdditingCreamToCocoaGetCostTest()
    {
    Drink cocoaWithCream=new AdditiveCream(cocoa);
    double expected=280;
    double actual=cocoaWithCream.GetCost();
     Assert.AreEqual(expected,actual);
    }
[TestMethod]
    public void AdditingSugarToChocolateGetCostTest()
    {
    Drink chocolateWithoneSpoonOfSugar=new AdditiveSugar(chocolate);
    double expected=270;
    double actual=chocolateWithoneSpoonOfSugar.GetCost();
     Assert.AreEqual(expected,actual);
    }
 [TestMethod]
    public void AdditingMilkToChocolateGetCostTest()
    {
    Drink chocolatewithMilk=new AdditiveMilk(chocolate);
    double expected=285;
    double actual=chocolatewithMilk.GetCost();
     Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void AdditingCreamToChocolateGetCostTest()
    {
    Drink chocolateWithCream=new AdditiveCream(chocolate);
    double expected=300;
    double actual=chocolateWithCream.GetCost();
     Assert.AreEqual(expected,actual);
    }

    [TestMethod]
    public void AdditingManyToCoffeeGetCostTest()
    {
    Drink bigCoffee = new AdditiveMilk (
      new AdditiveCream (
         new AdditiveSugar (
            coffee
         )
      )
    );
    double expected=280;
    double actual=bigCoffee.GetCost();
     Assert.AreEqual(expected,actual);
    }
[TestMethod]
    public void AdditingManyMilkToChocolateGetCostTest()
    {
    Drink sweetChocolate = new AdditiveMilk (
      new AdditiveMilk (
         new AdditiveSugar (
            new AdditiveSugar (
               chocolate
            )
         )
      )
    );
    double expected=330;
    double actual=sweetChocolate.GetCost();
     Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void AdditingManyMilkToCacaoGetCostTest()
    {
    Drink sweetCocoa = new AdditiveMilk (
      new AdditiveCream (
         new AdditiveSugar (
            new AdditiveSugar (
               cocoa
            )
         )
      )
    );
    double expected=325;
    double actual=sweetCocoa.GetCost();
     Assert.AreEqual(expected,actual);
    }
    //CoffeeMachineModel Tests
   [TestMethod]
    public void CoffeeMachineModelAddIngridientSugarTest()
    {
  
    CoffeeMachineModel machineModel=new CoffeeMachineModel();
    machineModel.AddIngridient(DrinkIngredient.Coffee);
    machineModel.AddIngridient(DrinkIngredient.Sugar);
    double expected= 215;
   double actual= machineModel.CurrentDrink.GetCost();
   Assert.AreEqual(expected,actual);
    } 
    [TestMethod]
     public void CoffeeMachineModelAddIngridientCreamTest()
    {
  
    CoffeeMachineModel machineModel=new CoffeeMachineModel();
    machineModel.AddIngridient(DrinkIngredient.Coffee);
    machineModel.AddIngridient(DrinkIngredient.Cream);
    double expected= 245;
   double actual= machineModel.CurrentDrink.GetCost();
   Assert.AreEqual(expected,actual);
    }   
    [TestMethod]  
 public void CoffeeMachineModelAddIngridientMilkTest()
    {
  
    CoffeeMachineModel machineModel=new CoffeeMachineModel();
    machineModel.AddIngridient(DrinkIngredient.Coffee);
    machineModel.AddIngridient(DrinkIngredient.Milk);
    machineModel.AddIngridient(DrinkIngredient.Cream);
    double expected= 270;
   double actual= machineModel.CurrentDrink.GetCost();
   Assert.AreEqual(expected,actual);
    }   

 [TestMethod]  
 public void CoffeeMachineModelAddIngridientManyIngredientsToCoffeeTest()
    {
  
    CoffeeMachineModel machineModel=new CoffeeMachineModel();
    machineModel.AddIngridient(DrinkIngredient.Coffee);
    machineModel.AddIngridient(DrinkIngredient.Milk);
    machineModel.AddIngridient(DrinkIngredient.Sugar);
    machineModel.AddIngridient(DrinkIngredient.Sugar);
    machineModel.AddIngridient(DrinkIngredient.Cream);
    double expected= 290;
   double actual= machineModel.CurrentDrink.GetCost();
   Assert.AreEqual(expected,actual);
    }   
     [TestMethod]  
 public void CoffeeMachineModelAddIngridientManyIngredientsToChocolateTest()
    {
  
    CoffeeMachineModel machineModel=new CoffeeMachineModel();
    machineModel.AddIngridient(DrinkIngredient.Chocolate);
    machineModel.AddIngridient(DrinkIngredient.Milk);
     machineModel.AddIngridient(DrinkIngredient.Milk);
      machineModel.AddIngridient(DrinkIngredient.Sugar);
       machineModel.AddIngridient(DrinkIngredient.Sugar);
    double expected= 330;
   double actual= machineModel.CurrentDrink.GetCost();
   Assert.AreEqual(expected,actual);
    }   

     [TestMethod]  
 public void CoffeeMachineModelAddIngridientManyIngredientsToCocoaTest()
    {
  
   CoffeeMachineModel machineModel=new CoffeeMachineModel();
   machineModel.AddIngridient(DrinkIngredient.Cocoa);
   machineModel.AddIngridient(DrinkIngredient.Milk);
   machineModel.AddIngridient(DrinkIngredient.Milk);
   machineModel.AddIngridient(DrinkIngredient.Sugar);
   machineModel.AddIngridient(DrinkIngredient.Sugar);
   double expected= 310;
   double actual= machineModel.CurrentDrink.GetCost();
   Assert.AreEqual(expected,actual);
    }  

      [TestMethod]  
 public void CoffeeMachineModelRemoveAdditiveSugarFromCoffeeTest()
    {
  
   CoffeeMachineModel machineModel=new CoffeeMachineModel();
   machineModel.AddIngridient(DrinkIngredient.Coffee);
   machineModel.AddIngridient(DrinkIngredient.Milk);
   machineModel.AddIngridient(DrinkIngredient.Milk);
   machineModel.RemoveAdditive(DrinkIngredient.Sugar);
   double expected= 255;
   double actual= machineModel.CurrentDrink.GetCost();
   Assert.AreEqual(expected,actual);
    }  
    
      [TestMethod]  
 public void CoffeeMachineModelRemoveAdditiveMilkFromCoffeeTest()
    {
  
   CoffeeMachineModel machineModel=new CoffeeMachineModel();
   machineModel.AddIngridient(DrinkIngredient.Coffee);
   machineModel.AddIngridient(DrinkIngredient.Milk);
   machineModel.AddIngridient(DrinkIngredient.Sugar);
   machineModel.RemoveAdditive(DrinkIngredient.Milk);
   double expected= 215;
   double actual= machineModel.CurrentDrink.GetCost();
   Assert.AreEqual(expected,actual);
    }  
    
      [TestMethod]  
 public void CoffeeMachineModelRemoveAdditiveCreamFromCoffeeTest()
    {
  
   CoffeeMachineModel machineModel=new CoffeeMachineModel();
   machineModel.AddIngridient(DrinkIngredient.Coffee);
   machineModel.AddIngridient(DrinkIngredient.Milk);
   machineModel.AddIngridient(DrinkIngredient.Cream);
   machineModel.RemoveAdditive(DrinkIngredient.Cream);
   double expected= 230;
   double actual= machineModel.CurrentDrink.GetCost();
   Assert.AreEqual(expected,actual);
    }  

    
      [TestMethod]  
 public void CoffeeMachineModelRemoveAdditiveSugarFromCocoaTest()
    {
  
   CoffeeMachineModel machineModel=new CoffeeMachineModel();
   machineModel.AddIngridient(DrinkIngredient.Cocoa);
   machineModel.AddIngridient(DrinkIngredient.Milk);
   machineModel.AddIngridient(DrinkIngredient.Sugar);
   machineModel.RemoveAdditive(DrinkIngredient.Sugar);
   double expected= 265;
   double actual= machineModel.CurrentDrink.GetCost();
   Assert.AreEqual(expected,actual);
    }  

    
      [TestMethod]  
 public void CoffeeMachineModelRemoveAdditiveMilkFromChocolateTest()
    {
  
   CoffeeMachineModel machineModel=new CoffeeMachineModel();
   machineModel.AddIngridient(DrinkIngredient.Chocolate);
   machineModel.AddIngridient(DrinkIngredient.Milk);
   machineModel.AddIngridient(DrinkIngredient.Cream);
   machineModel.RemoveAdditive(DrinkIngredient.Milk);
   double expected= 300;
   double actual= machineModel.CurrentDrink.GetCost();
   Assert.AreEqual(expected,actual);
    }  

    
      [TestMethod]  
 public void CoffeeMachineModelRemoveAdditiveCreamFromCocoaTest()
    {
  
   CoffeeMachineModel machineModel=new CoffeeMachineModel();
   machineModel.AddIngridient(DrinkIngredient.Cocoa);
   machineModel.AddIngridient(DrinkIngredient.Milk);
   machineModel.AddIngridient(DrinkIngredient.Cream);
   machineModel.RemoveAdditive(DrinkIngredient.Cream);
   double expected= 265;
   double actual= machineModel.CurrentDrink.GetCost();
   Assert.AreEqual(expected,actual);
    }  
}