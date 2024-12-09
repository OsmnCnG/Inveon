// See https://aka.ms/new-console-template for more information
using InveonBootcamp._02.OCP;
using InveonBootcamp._03.LSP;
using InveonBootcamp._05.DIP.Interfaces;
using InveonBootcamp._05.DIP.Repository;
using InveonBootcamp._05.DIP.Services;
using InveonBootcamp._06.AsyncPart;
using System.Diagnostics;

Console.WriteLine("Hello, Inveon!");



Console.WriteLine("********** OCP **********");


//1.Without Using Delegate or Interface
var basePrice = 10000;

var calculateFirstDiscount = DiscountCalculator.CalculateDiscount(basePrice,DiscountCalculator.RentalPeriodType.ThreeDays);
Console.WriteLine($" discount_1:  {calculateFirstDiscount}");
var calculateSecondDiscount = DiscountCalculator.CalculateDiscount(basePrice, DiscountCalculator.RentalPeriodType.Weekly);
Console.WriteLine($" discount_2:  {calculateSecondDiscount}");
var calculateThirdDiscount = DiscountCalculator.CalculateDiscount(basePrice, DiscountCalculator.RentalPeriodType.Monthly);
Console.WriteLine($" discount_3:  {calculateThirdDiscount}");




//2.With Using Delegate
var calculateDiscountOCP1 = new DiscountCalculator3Days();
var discountOcp = calculateDiscountOCP1.CalculateDiscountOCP(basePrice);
Console.WriteLine($" discount_OCP:  {discountOcp}");

var calculateDiscountOCP2 = new DiscountCalculatorWeekly();
//var discountOcp2 = calculateDiscountOCP2.CalculateDiscountOCP(basePrice); // bunun yerine delegate kullanmaya karar verdim
var discountOcp2 = calculateDiscountOCP2.CalculateDiscountDelagate(basePrice, basePrice => basePrice * 15 / 100);
Console.WriteLine($" discount_OCP2:  {discountOcp2}");

var calculateDiscountOCP3 = new DiscountCalculatorMonthly();
var discountOcp3 = calculateDiscountOCP2.CalculateDiscountDelagate(basePrice, basePrice => basePrice *30 / 100);
Console.WriteLine($" discount_OCP3:  {discountOcp3}");



Console.WriteLine("********** LSP **********");


Vehicle tesla = new Tesla();

tesla.Charge();
tesla.Run();

Vehicle volvo = new Volvo();

//volvo.Charge(); // Hata fırlatmak yerine kullanıcıya bunu göstermeyip LSP ye uygun hale getirmeliyiz.
volvo.Run();


VehicleLSP volvo2 = new VolvoLSP();

volvo2.Run();

VehicleLSP vehicle = new TeslaLSP();

if (vehicle is IRechargeable thisIsTesla)
{
    thisIsTesla.Charge();
}



Console.WriteLine("**********Dependency Inversion Prinsiple**********");

var vehicleRepository = new VehicleRepository();

IVehicleService vehicleService = new VehicleService(vehicleRepository);


foreach(var item in vehicleService.GetVehicles())
{
    Console.WriteLine($"{item.Id}/{item.Model}/{item.Brand}/{item.Name}");
}

//Bölüm 2


//Async part.01
Console.WriteLine("********** Async - Sync **********");

Stopwatch sw = Stopwatch.StartNew();

var response1 = AsyncMethod_01.GetPostFromInstagram();
var response2 = AsyncMethod_01.GetProfileDetailFromInstagram();

var results = await Task.WhenAll(response1, response2);

sw.Stop();
Console.WriteLine($"Await kullanmadığımızda işlem süresi: { sw.ElapsedMilliseconds} ms");

Stopwatch swAsync = Stopwatch.StartNew();

var responseASync =  await AsyncMethod_01.GetPostFromInstagram();
var responseASync2 = await AsyncMethod_01.GetProfileDetailFromInstagram();

swAsync.Stop();
Console.WriteLine($"Await kullandığımızda işlem süresi: { swAsync.ElapsedMilliseconds } ms");
Console.WriteLine("Birbirinden bağımsız iki işlem için await kullanılması gereksiz süreyi uzatıyor.");



//Async part.02

var responseAsync = await AsyncMethod_03.GetShortLivedAccessTokenAsync();

//işlem önceki işlemin bitmesine bağlı bu yüzden await kullanılmalı
var responseAsync2 = await AsyncMethod_03.GetLongLivedAccessTokenAsync(responseAsync);




//Async part.03
Console.WriteLine("********** Task Metotları **********");

//TasksMethods.MultiThread();
//TasksMethods.MultiThreadTaskParallel();
Console.ReadKey();



