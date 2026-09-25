using System;
using System;
using System.Collections;
using System.Collections.Generic;
using day10_G01;
using System.Linq;
using static day10_G01.ListGenerators;
using System.Reflection.Metadata.Ecma335;
using System.Net.WebSockets;
using System.Threading;
using System.Security.Cryptography;
using System.Net.Http.Headers;

namespace Linq_EFDay01
{
    internal class Program
    {
        public static int SumArrList(ArrayList AL)
        {
            int Sum = 0;
            for (int i = 0; i < AL.Count; i++)
            {
                // Developing : take care
                Sum += (int)AL[i];
                // UnSafe ? 
                // Exceeption : Invalidcast
            }
            return Sum;
        }
        static void Main()
        {
            #region Collection _ Level 0
            // 1- Array >> one step retreival, fixed size

            //// DS : Dot Net >> Collections
            //// Level 0 :
            //// standard set of types Provide to store colection of objects

            //// interfaces >> set collection protocols
            //// build collection >> Tuples , classes + modification
            //// ready to use colections : store set of data

            //// Array : 
            //// same DT , Get any element in one step(Sequence)
            //// Add >> Fixed Size 

            //// Array List
            //// System.Collections : Non generic collections;
            //// array but dynamic size 
            //// internally array of objects >> Source browser 
            //// Heterogeneous >> 
            //// Before Generics ?

            //ArrayList arrayList = new ArrayList();
            //// Capacity  >> can contain How many ?
            //// Count  >>  no of actual elements in this
            //Console.WriteLine(arrayList.Capacity);//0
            //Console.WriteLine(arrayList.Count);   //0

            // Adding for elements : 
            // behavior of array List :
            // Dynamic behavior :
            // Default bahavior :
            // new array with capacity 4 >>> Self 

            //arrayList.Add(1);
            //Console.WriteLine(arrayList.Capacity);//4
            //Console.WriteLine(arrayList.Count);   //1
            //arrayList.Add(2);
            //arrayList.Add(3);
            //arrayList.Add(4);
            //Console.WriteLine(arrayList.Capacity);//4
            //Console.WriteLine(arrayList.Count);   //4

            //// Exceed size/capacity
            //// new array with which capacity ? Double old capacity
            //// Copy old elements and adding the new 
            //arrayList.Add(5);
            //Console.WriteLine(arrayList.Capacity);//8
            //Console.WriteLine(arrayList.Count);   //5

            //arrayList.AddRange(new int[] { 4, 6 });
            //Console.WriteLine(arrayList.Capacity);//8
            //Console.WriteLine(arrayList.Count);   //7

            ////// free unused bytes 
            //arrayList.TrimToSize();
            //// Count = Capcity;
            //Console.WriteLine(arrayList.Capacity);//5
            //Console.WriteLine(arrayList.Count);   //5

            //// array of objects : 
            //arrayList.Add("Abdo");

            //// functionality >> Problems :
            //// 1- Casting >> Boxing >> optimizing memory
            //// 2- Developing overhead >> object Parent of all DT
            //// Protective code 
            //// Design >> not scalable >> depend on object
            //// Compiler can't enforce type safety

            //Console.WriteLine(SumArrList(arrayList));//25
            ////System.InvalidCastException

            //// Solution : 
            //// Array >> Array List 
            //// Generic Version of Array List
            //// 2005 : C# 2.0
            //// System.Collections.Generic

            ////List<> : internally array ?!

            //Console.Clear();
            //List<int> list = new List<int>();
            ////// Compiler can enforce type safety , int only
            //Console.WriteLine(list.Capacity);//0
            //Console.WriteLine(list.Count);   //0
            //list.Add(1);
            //Console.WriteLine(list.Capacity);//4
            //Console.WriteLine(list.Count);   //1
            //list.Add(2);
            //list.Add(3);
            //list.Add(4);
            //Console.WriteLine(list.Capacity);//4
            //Console.WriteLine(list.Count);   //4
            //list.Add(5);
            //Console.WriteLine(list.Capacity);//8
            //Console.WriteLine(list.Count);   //5
            ////Delete unused :
            //list.TrimExcess();
            ////list.Capacity = list.Count;
            //Console.WriteLine(list.Capacity);//5
            //Console.WriteLine(list.Count);   //5
            ////// Index management
            //list[1] = 14; // Set = update
            //Console.WriteLine(list[1]); // get = retreive //14
            //list[5] = 6; // u can't add with Index : out of range 

            //// built_in functions >> self
            #endregion

            #region var (implicit typed local variable)
            // Implicit typed local variable (dynamic , var)
            // scope { }
            // Implicit : not detect type explicit(Compiler)
            //int X = 5;
            //var Y = "Ali";
            //var C = null;
            //var U;
            //X = "Ismail"
            //Y = 8;
            //Y = null; // assign with null
            // Compiler detect (variable declared with var) datatype based on its initial value at compilation time

            // dynamic >>  Web >> Self 
            #endregion

            #region EM
            //// Extension Methods : 
            //int X = 12345, Y;
            ////Y = 54321 ; Functionality ?
            //Y = IntExtension.Reverse(X);
            //Console.WriteLine(Y); //54321
            //// More Readable >> built_in function in int 

            ////Extension methods ? 
            //// Extend functionality to int 
            //// Extend functionality to any built_in type
            //// Extend functionality to Built_in Type ?  EM

            //Y = X.Reverse(); // Readable // Syntax sugar
            //Console.WriteLine(Y); //54321

            //int[] arr = { 1, 2, 3, 4 };
            //arr.GetLength(0);

            ////// built in fun array

            //long K = 123, M;
            //M = K.Reverse();
            //Console.WriteLine(M);
            #endregion

            #region Anonymous type
            //// Anonymous Type :
            //Employee Emp01  = new Employee() { Id=1,Name="Ali",Salary=3455};
            //object Emp02 = new { Id = 1, Name = "Ali", Salary = 3455.0 }; // Compiler
            //Console.WriteLine(Emp02.Name);//"Ali"


            //var Emp03 = new { Id = 1, Name = "Ali", Salary = 3455 }; // Compiler 
            //Console.WriteLine(Emp03.Name);//"Ali"
            //Console.WriteLine(Emp03);//{ Id = 1, Name = Ali, Salary = 3455 }

            //// Problem:
            //// AT : Immutable > Read Only > can't be aassigned to
            //// obj from anonumous type     immutable : can't change its value
            //Emp03.Name = "Ismail";

            //// C# 10.0 , .net 6 
            //var Emp04 = Emp03 with { Name = "Ismail" };
            //Console.WriteLine(Emp04);

            //// the name of this anonymous type ?
            //int X = 10;
            //Console.WriteLine(X.GetType().Name);//Int32

            //// AT : inherit from object 
            //Console.WriteLine(Emp03.GetType().Name);//<>f__AnonymousType0`3
            //var Emp04 = new { Id = 2, Name = "Abdo", Salary = 3456 };
            //Console.WriteLine(Emp04.GetType().Name);//<>f__AnonymousType0`3
            //// the same type generated : 
            //// 1- order of parameters 
            //// 2- same Properties Name (Case Sensitive)
            //// 3- same Properties Data type

            //var Emp05 = new { id = 2, Name = "Abdo", Salary = 3456 };
            //Console.WriteLine(Emp05.GetType().Name);//<>f__AnonymousType1`3
            //var Emp06 = new { Id = 2, Name = "Abdo"};
            //Console.WriteLine(Emp06.GetType().Name);//<>f__AnonymousType2`2
            //var Emp07 = new { Name = "Abdo", id = 2, Salary = 3456 };
            //Console.WriteLine(Emp07.GetType().Name);//<>f__AnonymousType3`3

            //// Generated Type by compiler : 
            //// Self : Create   ,   Delete   Type >> when ? 
            #endregion

            #region LINQ intro
            //// LINQ: is stand for Language-Integrated Query
            //// LINQ: +40 Extension Methods (to the classes that implement IEnumerable interface)
            ////       Named as [Query Operators] Existing at Enumerable Class and Categorized to 13 Categories

            //// Use LINQ Functions Against Data (Sequence) Regardless Data Store
            //// Sequence: Any Class Implementing IEnumerable (Like List, Array, Dictionary...)
            //// 1. Local Sequence : L2O, L2XML (static - XML file)
            //// 2. Remote Sequence: L2EF (DB)

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var OddNumbers = Numbers.Where(N => N % 2 == 1);
            //foreach (var number in OddNumbers)
            //    Console.WriteLine(number);
            #endregion

            #region LINQ syntax
            ////LINQ Syntax
            ////1-Fluent syntax (write LINQ in C# syntax)
            ////2-Query syntax(expression)(Like SQL)
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, };

            //// 1-1 Calling linq operator as static methods through Enumerable class
            //var odd = Enumerable.Where(list, (N) => N % 2 == 1);
            //foreach (int i in odd)
            //    Console.WriteLine(i);
            //// 1-2 Calling linq operator as as EM for list (List) > [Recommended]
            //// syntax sugar
            //odd = list.Where((N) => N % 2 == 1);
            //foreach (int i in odd)
            //    Console.WriteLine(i);

            //2 - Query expression(like sql server style)
            // Start With from, Introducing Range Variable(N): Represents Each Element At Sequence
            // End With select Or group by
            /*
             select * 
            from list L
            where L % 2 = 1
            have to write it in execution order
             */
            //var odd = from N in list
            //          where N % 2 == 1
            //          select N;
            #endregion

            #region LINQ Execution
            //Linq Execution 
            //// Ways Of LINQ Execution
            // Deferred : line executed when used --- not immediately
            // 1. Deferred Execution (Latest Update Of Data) (10 categories of 13)
            // All LINQ Operators Except Element, Aggregate, Casting Operators
            List<int> Num = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var OddNum = Num.Where(N => N % 2 == 1);
            Num.AddRange(new[] { 11, 12, 13 });
            foreach (var item in OddNum) //1,3,5,7,9 // 11,13
                Console.WriteLine(item);

            // Query Mode
            // Data Mode

            //// 2. Immediate(eager) Execution [casting-element-aggregate]
            ////For Converting Deferred Executing LINQ Operators to Immediate >>
            //// Use one of Immediate
            //// Using Casting For Converting Deffered Executing LINQ Operators 
            List<int> Num2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // scenario 01
            var OddNum2 = Num2.Where(N => N % 2 == 1)
                .ToList();

            // Query Mode : filter in sql server
            // Data Mode : (Materialization) : physical : List
            // Cache (Ram) (filtered only !)

            //// scenarion 02
            //// Early Materilaize
            var Res = Num2.ToList()
                .Where(N => N % 2 == 1);

            // Early Materialization
            // Data Mode : (Materialization) : physical : List : Ram
            // Query Mode : filter in App (Cache/Ram)


            //Num2.AddRange(new[] { 11, 12, 13 });
            //foreach (var item in OddNum2) // 1 3 5 7 9  
            //    Console.WriteLine(item);

            // Yielding     >> Self
            // Lazy Loading >> Self
            #endregion

            #region Data Environment
            //// static Data 
            // Data environment
            //Console.WriteLine(ListGenerators.ProductList[0]);
            //Console.WriteLine(ListGenerators.CustomerList[0]);

            //Console.WriteLine(CustomerList[0]); 
            #endregion


            #region Filteration Category
            //// filteration / restriction
            //// where

            //// 1
            ////1- out of stock
            // filter products out of stock :
            // function >> info / Condition 
            // Product > bool
            //Func<Product,bool> Predicate01 = ProductFilter.IsOutOfStock;
            //var Res01 = ProductList.Where(Predicate01);
            //foreach (var item in Res01)
            //{
            //    Console.WriteLine(item);
            //}
            // IsCondiments : 
            //Func<Product, bool> Predicate02 = ProductFilter.IsCondiments;
            //ProductList.Where(Predicate02);
            //var Res02 = ProductList.Where(ProductFilter.IsCondiments);
            //foreach (var item in Res02)
            //{
            //    Console.WriteLine(item);
            //}
            // 3- IsOutOfStockAndIsCondiments in same time  

            //// for each functionality represent Condition -> user defined function in user defined class !
            //// Aninymous function > lambda expression
            //// 2
            //// 1- Out of stock : 
            //var Res01 = ProductList.Where((P) => P.UnitsInStock == 0);
            //// 2- IsCondiments :
            //var Res02 = ProductList.Where((P) => P.Category == "Condiments");
            //// 3- IsCondiments and out of stock :
            //var Res03 = ProductList.Where((P) => P.Category == "Condiments" && P.UnitsInStock == 0);
            ////foreach (var item in Res03)
            ////{
            ////    Console.WriteLine(item);
            ////}

            //// Fluent syntax : 
            //// 1- static methd
            //var Res04 = Enumerable.Where(ProductList, (P) => P.UnitsInStock == 0);
            //// 2- extension methd [Recommended]
            //var Res05 = ProductList.Where((P) => P.UnitsInStock == 0);
            //// Sql style :
            //var Res06 = from P in ProductList
            //            where P.UnitsInStock == 0
            //            select P;


            //var Res02=ProductList.Where((P) => P.UnitsInStock < 10);
            //foreach (var item in Res02)
            //{
            //    Console.WriteLine(item);
            //}
            //Func<Product, bool> predicatte02 = ProductFilter.IsCondiments;
            //var Result002 = ProductList.Where(ProductFilter.IsCondiments);
            //Func<Product, bool> predicatte03 = ProductFilter.IsOutOfStockAndIsCondiments;
            //var Result003 = ProductList.Where(ProductFilter.IsOutOfStockAndIsCondiments);

            //// 2
            //// fluent syntax
            //var Result01 = ProductList.Where((P) => P.UnitsInStock == 0);
            //// Query syntax
            //var Result02 = from P in ProductList
            //               where P.UnitsInStock == 0
            //               select P;
            ////2- Is category > condiments
            //var Result03 = ProductList.Where((P) => P.Category == "Condiments");
            //var Result04 = from P in ProductList
            //               where P.Category == "Condiments"
            //               select P;
            //// Both :
            //var Result05 = ProductList.Where((P) => P.Category == "Condiments" && P.UnitsInStock == 0);
            //var Result06 = from P in ProductList
            //               where P.Category == "Condiments" && P.UnitsInStock == 0
            //               select P;

            // +40 EM :
            // linq operator >> +40 !!
            // 40 > + > overloads 
            // Where !! : 2 overloads 

            //// second overload
            //// first 10 out of stock
            //// Indexed Where
            //// valid only in fluent syntax -- 77 products
            //var Ress = ProductList.Where((P, I) => P.UnitsInStock == 0 && I < 10);

            //foreach (var item in Ress)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Transformation (Projection Operators) - Select / SelectMany
            //// select
            //// input    ---     output

            // Level 01
            //// Product names from product list
            //// fluent syntax
            //var Res=ProductList.Select((P) => P.ProductName);
            //// Query syntax
            //Res = from P in ProductList
            //      select P.ProductName;
            //foreach (var item in Res)
            //{
            //    Console.WriteLine(item);
            //}

            ////customer Names (each customer has one name) => select
            //// fluent syntax
            //var Res02 = CustomerList.Select((C) => C.Name);

            //// Query syntax
            //var Result03 = from Customer in CustomerList
            //               select Customer.Name;
            //foreach (var item in Res02)
            //{
            //    Console.WriteLine(item);
            //}

            // level 02 
            // Anonymous Type !!
            //// id and name for each product
            //// Select Anonymous Type
            //var Res03=ProductList.Select((P) => new { P.ProductID,P.ProductName});
            //var Res = ProductList.Select((P) => new
            //{
            //     P.ProductID,
            //     P.ProductName,
            //     P.UnitPrice
            //});
            // Query Syntax
            //var Result06 = from P in ProductList
            //               select new { P.ProductID, P.ProductName };
            //foreach (var item in Res03)
            //{
            //    Console.WriteLine(item);
            //}

            // level 03 (Chaining)
            //// product Id and name for out of stock products
            //// Purpose: Filter the list first, then project the filtered results.
            //// CLean Code :
            //// reduce cognitive load
            //// one Dot per line >> Rule
            // .where()
            //.select()
            //.Take(5)
            //ProductList.Where((P) => P.UnitsInStock == 0)
            //           .Select((P) => new { P.ProductID, P.ProductName });
            //var Result02 = ProductList.Select((P) => new { P.ProductID, P.ProductName,P.UnitsInStock}).Where((P) => P.UnitsInStock == 0);

            //var Result03 = from P in ProductList
            //               where P.UnitsInStock == 0
            //               select new { P.ProductID, P.ProductName };

            // level04 (clean)
            ////// Clean code : 
            ////// reduce cognitive load 
            ////// one Dot per line
            //ProductList.Where((P) => P.UnitsInStock == 0)
            //           .Select((P) => new { P.ProductID, P.ProductName });
            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item);
            //}

            // level04 (common sense-alias)
            //// get id,name, new price of discounted product to 20 % that more than 60 item in stock
            //// note : alias name for columns in projection and also logic
            //var Res05 = ProductList.Where((P) => P.UnitsInStock > 60)
            //    .Select((P) => new
            //    {
            //        Id=P.ProductID,
            //        Name=P.ProductName,
            //        NewPrice=P.UnitPrice*0.8M
            //    });
            //foreach (var item in Res05)
            // {
            //     Console.WriteLine(item.NewPrice);
            // }




            // Query Syntax
            //Res = from P in ProductList
            //            where P.UnitsInStock > 60
            //            select new
            //            {
            //                Id = P.ProductID,
            //                Name = P.ProductName,
            //                NewPrice = P.UnitPrice * 0.8M
            //            };
            //foreach (var item in Res)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in Res)
            //{
            //    Console.WriteLine(item.NewPrice);
            //}

            //===========================

            //// second overload
            //// Indexed Select (Valid Only at Fluent Syntax)
            //var Ress=ProductList.Select((P, I) => new
            //{
            //    P.ProductID,
            //    Index = I + 1
            //});
            //foreach (var item in Ress)
            //{
            //    Console.WriteLine(item);
            //}

            //===========================

            // level05
            ////customer Orders (each customer has More than one order) => selectMany
            //// 1- select : print namespace of array (NS.object)
            //// fluent syntax
            //// Project nested structure
            //// array  >>  list  >> nested structure
            //var Res10=CustomerList.Select((C) => C.Orders);
            //// Query syntax
            //Result = from Customer in CustomerList
            //         select Customer.Orders;
            //foreach (var item in Res10)
            //{
            //    Console.WriteLine(item);
            //}

            ////customer Orders (each customer has More than one order) => selectMany
            //// 2- SelectMany : elements of array (object itself)
            //// fluent syntax
            //var Res11 = CustomerList.SelectMany((C) => C.Orders);
            //// Query syntax
            //var Result03 = from Customer in CustomerList
            //               from order in Customer.Orders
            //               select order;
            //foreach (var item in Res11)
            //{
            //    Console.WriteLine(item);
            //}

            //nested structure >> select many
            //Primitive >> Select
            // Flatten nested structure ?
            // Use Cases >> Select Many >> alternative ?  >> self
            #endregion

            #region Ordering Operators
            ////ordering operator(OrderBy-ThenBy-OrderByDesc-ThenByDesc-Reverse)
            //// Ascending Order
            //var res=ProductList.OrderBy((P) => P.UnitPrice);
            //var Result02 = from P in ProductList
            //               orderby P.UnitPrice
            //               select P;
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //// Descending Order
            //var res01 = ProductList.OrderByDescending((P) => P.UnitPrice);
            //Result = from P in ProductList
            //         orderby P.UnitPrice descending
            //         select P;
            //foreach (var item in res01)
            //{
            //    Console.WriteLine(item);
            //}

            //// OrderBy Multiple Columns Asc
            //var res02=ProductList.OrderBy((P) => P.UnitPrice)
            //     .ThenBy((P) => P.UnitsInStock);
            //var Result02 = from P in ProductList
            //               orderby P.UnitPrice, P.UnitsInStock
            //               select P;
            //foreach (var item in res02)
            //{
            //    Console.WriteLine(item);
            //}

            //// OrderBy Multiple Columns Desc
            //var Result01 = ProductList.OrderByDescending((P) => P.UnitPrice)
            //    .ThenByDescending((P) => P.UnitsInStock);
            //var Result02 = from P in ProductList
            //               orderby P.UnitPrice descending, P.UnitsInStock descending
            //               select P;
            //foreach (var item in Result01)
            //{
            //    Console.WriteLine(item);
            //}
            //// u can make one asc and the other descending and viceversa

            //// Reverse Operator
            //var res03 = ProductList.Where((P) => P.UnitsInStock == 0)
            //    .Reverse();

            //foreach (var item in res03)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            // Linq operators >> 13 category
            // 10 : deferred execution
            // 3 : immediate execution
            // filteration(where) - Projetion(select) - Ordering(orderby) >> deferred execution
            // (3:immediate Exec(Element,Aggregate,Casting),10:deferred Exec)
            #region  Element Operators - Immediate Execution
            //// Element operators :
            //// (First/Last/FirstOrDefault/LastOrDefault/ElementAt/ElementAtOrDefault/Single/SingleOrDefault)

            //// First overload >> Hybrid syntax
            //var Res = ProductList.First();
            //var Res01 = ProductList.Last();
            //Console.WriteLine(Res01?.ProductName??"NA");


            ////Empty Sequence
            ////System.InvalidOperationException
            //// Throw Exception, Because The Sequence (Products) is Empty
            //List<Product> Products = new List<Product>();
            //var Res = Products.First();
            //Res = Products.Last();

            //var Res01 = Products.FirstOrDefault();
            //var Res02 = Products.LastOrDefault();
            //var Res03 = ProductList.LastOrDefault();
            //// Return The First/Last Element at Sequence or Return DefaultValue[Null] if Sequence is Empty
            //// No Exceptions Will be Thrown
            //Console.WriteLine(Res03?.ProductName ?? "NA"); 

            //// 2nd Overload
            //ProductList.First((P) => P.UnitPrice < 1000);
            //// If No Element doesn't Match Condition, Will Throw Exception
            //var Res2 = ProductList.FirstOrDefault((P) => P.UnitPrice < 1000);
            //// If No Element doesn't Match Condition, Will Return Null
            //Console.WriteLine(Res2?.ProductName ?? "NA");

            //var Res = ProductList.ElementAt(200);
            //// If there is No Element, Will Throw Exception(ArgumentOutOfRangeException)
            //var Res = ProductList.ElementAtOrDefault(200); // If there is No Element, Will Return Null
            //Console.WriteLine(Res?.ProductName??"NA");

            //var Res = Products.Single(); // Throw Exception
            //var Res = ProductList.Single(); // Throw Exception
            //// If Sequence Conatins Just Only One Element, Will Return it
            //// Else Will Throw Exception (Sequence is Empty or Containts More than One Element)
            //Products.Add(ProductList[0]);
            //var Res = Products.Single(); // Return Single Element

            //var Res = Products.SingleOrDefault();
            //// If Sequence is Empty, Will Return Null
            //// If Sequence Conatins Just Only One Element, Will Return it
            //// If Sequence Conatins More than One Element, Throw Exception
            //Console.WriteLine(Res?.ProductName??"NA");

            //2nd Overload
            //var Res = ProductList.Single(P => P.ProductID == 100);
            //// If Sequence Conatins Just Only One Element Matching the Condition, Will Return it
            //// Throw Exception, if Zero Or More than One Element is Matching the Condition

            //var Res = ProductList.SingleOrDefault(P => P.UnitPrice > 4);
            //// If Sequence Conatins No Element Matching Condition, Will Return Null
            //// If Sequence Conatins Just Only One Element Matching Condition, Will Return it
            //// If Sequence Conatins More than One Element Matching Condition, Will Throw Exception

            //// Valid Only with Fluent Syntax
            //// Hybrid Syntax: (Query Expression).FluentSyntax
            //var Res = (from P in ProductList
            //           where P.UnitsInStock == 0
            //           select new
            //           {
            //               ID = P.ProductID,
            //               Name = P.ProductName,
            //               Count = P.UnitsInStock
            //           }).FirstOrDefault();
            //Console.WriteLine(Res?.Name ?? "NA");
            #endregion

            #region Aggregate Operators - Immediate Execution
            ////Aggregate operators
            ////Count - Max - Min - Average - Sum 
            //var Res = ProductList.Count();
            //Res = ProductList.Count;
            //// No Diff (just only count > use prop not operator)
            //// the difference appears in 2nd overload
            //Res = ProductList.Count((P)=> P.UnitsInStock == 0);

            ////Max product (detect)
            //var Res1 = ProductList.Max();
            ////System.ArgumentException: At least one object must implement IComparable.
            //// depends on another function (CompareTo)
            //Console.WriteLine(Res1);
            ////Max productPrice 
            //var Res2=ProductList.Max((P) => P.UnitPrice);
            //Console.WriteLine(Res2);



            // level02

            // Min/Max : Product 
            // detect Max , Min
            // IComparable<Product>
            // Unit Price
            //ProductList.Min();// Product Min Unit Price
            //ProductList.Max();// Product Max Unit Price

            //ProductList.Max(P => P.UnitPrice);// Max Unit Price
            //ProductList.Min(P => P.UnitPrice);// Min Unit Price

            // Min Length of Product Name
            //ProductList.Min(P => P.ProductName.Length);

            // Product that has Min Length of Product Name
            // Method Chaining 
            //var res=ProductList.Where(P => P.ProductName.Length == ProductList.Min(P => P.ProductName.Length))
            //    .FirstOrDefault();
            //Console.WriteLine(res);
            // self : tarnslate to SQL


            // Min Product of Price
            // 1- Product with min Price
            //var Res = ProductList
            //.Where(P => P.UnitPrice == ProductList
            //.Min(P => P.UnitPrice))
            //.FirstOrDefault();

            //Console.WriteLine(Res);

            // Query Expression (Pure)(element-aggreagate-casting)

            ////Hybrid Syntax
            //// (Query).Fluent
            //var Res02 = (from P in ProductList
            //            where P.UnitPrice == ProductList.Min(P => P.UnitPrice)
            //            select P).FirstOrDefault();
            //Console.WriteLine(Result);

            ////total prices and average of all products
            //Console.WriteLine(ProductList.Sum((P) => P.UnitPrice));
            //Console.WriteLine(ProductList.Average((P) => P.UnitPrice));

            // aggregate : self
            //string[] Names = { "Abdo", "Shaban", "Saleh", "Youssef" };
            //var Res = Names.Aggregate((str1, str2) => $"{str1} {str2}");
            //Console.WriteLine( Res); 
            #endregion

            #region Casting Operators - Immediate Execution
            ////Casting Operators
            IEnumerable<Product> res01= ProductList.Where((P) => P.UnitsInStock == 0);

            IEnumerable<Product> ProductsList = ProductList.Where((P) => P.UnitsInStock == 0)
                                                    .ToList();
            Product[] ProductsArray = ProductList.Where((P) => P.UnitPrice == 0)
                                                    .ToArray();

            //List<Product> Res02 = (from P in ProductList
            //                       where P.UnitsInStock == 0
            //                       select P).ToList();

            //Dictionary<long, Product> ProductsDictionary = ProductList.Where((P) => P.UnitsInStock == 0)
            //    .ToDictionary((P)=>P.ProductID);
            //Dictionary<long, string> ProductsNamesDictionary = ProductList.Where((P) => P.UnitsInStock == 0)
            //    .ToDictionary((P) => P.ProductID, (P) => P.ProductName);

            //HashSet<Product> ProductsSet = ProductList.Where((P) => P.UnitPrice == 0)
            //    .ToHashSet(); 
            #endregion

            #region Generator/Generation Operators
            // Range-Repeat-Empty
            // only generates - not take input sequence
            // PL.Range()  not valid
            // only fluent syntax 
            // The Only Way to Call them is as Static Methods from Enumerable Class

            ////Generate Range of integers
            //var Res1 = Enumerable.Range(0, 100);//0-99
            ////Generate sequence of repeated value
            //var Res2 = Enumerable.Repeat("Abdo", 5);
            //var Res3 = Enumerable.Repeat(new Product(), 100);

            //// Generate Empty and dynamic sequence
            //var Res4 = Enumerable.Empty<Product>();
            //var Res5 = Res4.ToList();
            //var Res6 = Res5.ToArray();
            //Product[] ProductsArray = new Product[0];
            //List<Product> ProductsList = new List<Product>();
            //foreach (var item in Res1)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Quantifiers Operators - Return Boolean Value
            //Any (Two overloads) Like in Js (Some)
            // هل ف اي عنصر عندك/يحقق الشرط
            //All (one overload) like in Js (Every)
            // هل كل العناصر اللي عندك بتحقق الشرط
            //SequenceEqual
            // الاتنين اللي عندك عندهم نفس العناصر
            //Console.WriteLine(
            //    //ProductList.Any() //  Return True If Input Sequence Have At Least One Element
            //    //ProductList.Any((P)=>P.UnitsInStock==0)// Return true If Just One Element Matched Condition
            //    //ProductList.Any((P)=>P.UnitPrice>2000)
            //    //ProductList.All((P)=>P.UnitsInStock==0)// Return True If All Elements Matched Condition
            //    //ProductList.All((P)=>P.UnitPrice>0)
            //    //Seq01.SequenceEqual(Seq02)
            //    );
            #endregion

            #region Partitioning Operators
            ////(Take, Skip, TakeLast, SkipLast, TakeWhile, SkipWhile)
            ////we use those operators to make pagination 
            //// will see this in API Project

            //// Get the first 3 Products that are Out Of Stock 
            //var Res1 = ProductList.Where((P) => P.UnitsInStock == 0)
            //                    .Take(3);
            //// Get the Last 3 Products that are Out Of Stock 
            //var Res2 = ProductList.Where((P) => P.UnitsInStock == 0)
            //                      .TakeLast(3);

            ////Get all but the first 2 Products that are Out Of Stock
            //var Res3 = ProductList.Where((P) => P.UnitsInStock == 0)
            //                      .Skip(2);

            //// Get all but the last 2 Products that are Out Of Stock 
            //var Res4 = ProductList.Where((P) => P.UnitsInStock == 0)
            //    .SkipLast(2);


            //foreach (var item in Res4)
            //    Console.WriteLine(item);


            //int[] Numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            ////// Get the elements starting from the beginning of the array until a number is hit that is
            ////// less than its position (index) in the array.
            //var Res1 = Numbers.TakeWhile((N, I) => N > I); // 5  4 
            //var Res2 = Numbers.Where((N, I) => N > I); // 5 4 9 8
            //////Note the difference
            ////// Get the elements of the array starting from the first element divisible by 3.
            //var Res3 = Numbers.SkipWhile((N) => N % 3 != 0);
            //foreach (var item in Res3)
            //    Console.WriteLine(item);

            #endregion



    //problem1

    var result = ListGenerators.ProductList
    .Where(p => p.UnitsInStock == 0);

foreach (var product in result)
{
    Console.WriteLine(product);
}


      //problem2
      //Find all products that are in stock and cost more than 3.00 per unit.
      var result = ListGenerators.ProductList
          .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00);

      foreach (var product in result)
      {
        Console.WriteLine(product);
      }

      //problem3
      //Returns digits whose name is shorter than their value.
      string[] Arr =
{
    "zero",
    "one",
    "two",
    "three",
    "four",
    "five",
    "six",
    "seven",
    "eight",
    "nine"
};

      var result = Arr.Where((word, index) => word.Length < index);

      foreach (var word in result)
      {
        Console.WriteLine(word);
      }



      //problem4

      //Get first Product out of Stock
      var result = ListGenerators.ProductList
    .First(p => p.UnitsInStock == 0);

      Console.WriteLine(result);

      //Element Operators

      //problem5
      //Get first Product out of Stock
      var result = ListGenerators.ProductList
    .First(p => p.UnitsInStock == 0);

      Console.WriteLine(result);

      //problem6
      //Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
      var result = ListGenerators.ProductList
          .FirstOrDefault(p => p.UnitPrice > 1000);

      Console.WriteLine(result);

      //problem7

      //Retrieve the second number greater than 5
      int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

      var result = Arr
          .Where(x => x > 5)
          .Skip(1)
          .First();

      Console.WriteLine(result);

      //Aggregate Operators

      //problem8
      //Uses Count to get the number of odd numbers in the array.
      int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

      var result = Arr.Count(x => x % 2 != 0);

      Console.WriteLine(result);

      //problem9
      //Return a list of customers and how many orders each has.
      var result = ListGenerators.CustomerList
    .Select(c => new
    {
      CustomerName = c.CompanyName,
      OrderCount = c.Orders.Count()
    });

      foreach (var customer in result)
      {
        Console.WriteLine(
            $"Customer: {customer.CustomerName}, Orders: {customer.OrderCount}"
        );
      }
      //problem10
      //Return a list of categories and how many products each has.

      var result = ListGenerators.ProductList
    .GroupBy(p => p.Category)
    .Select(g => new
    {
      Category = g.Key,
      ProductCount = g.Count()
    });

      foreach (var item in result)
      {
        Console.WriteLine(
            $"Category: {item.Category}, Products: {item.ProductCount}"
        );
      }

//problem11
//Get the total of the numbers in an array.

int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

var result = Arr.Sum();

Console.WriteLine(result);


















    }

  }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id is {Id},Name is {Name}, Salary is {Salary}";
        }
    }
    class Product02
    {
        public long ProductID { get; set; }
        public string ProductName { get; set; }
        public override string ToString()
        {
            return $"Id is {ProductID}, Name is {ProductName}";
        }
    }
    class ProductFilter
    {
        // info >> out of stock
        public static bool IsOutOfStock(Product product)
        {
            return product.UnitsInStock == 0;
        }
        // info >> Category : Condiments
        public static bool IsCondiments(Product product)
        {
            return product.Category == "Condiments";
        }
        public static bool IsOutOfStockAndIsCondiments(Product product)
        {
            return product.Category == "Condiments" && product.UnitsInStock == 0;
        }
        public static bool IsOutOfStockInFirstTen(Product product, int index)
        {
            return product.UnitsInStock == 0 && index < 10;
        }















































}
}
