using OopsLineComp;
//UC1
//UC1OopsLineComp Length = new UC1OopsLineComp();

//double length = Length.Length();
//Console.WriteLine("Length of the line is :" + length);
//UC2

/*UC2OopsLineComp L1 = new UC2OopsLineComp();
UC2OopsLineComp L2 = new UC2OopsLineComp();

// here print 1st L1 values

double length1 = L1.Length();
Console.WriteLine("LENGTH OF 1ST LINE :" + length1);
// done with 1st part

//now do the same thing for 2nd line

Console.WriteLine("ENTER THE VALUES OF L2");
double length2 = L2.Length();
Console.WriteLine("LENGTH OF 2ND LINE :" + length2);

//TO CHECK LINE LENGTH IS EQUAL OR NOT USE SIMPLE IF STATEMENT

if(length1.Equals(length2))
{
    Console.WriteLine("Lengths L1 & L2 are equal");
}
else
{
    Console.WriteLine("Lengths L1 & L2 are not equals");
}
*/

//UC3
UC2OopsLineComp L1 = new UC2OopsLineComp();
UC2OopsLineComp L2 = new UC2OopsLineComp();

// here print 1st L1 values

double length1 = L1.Length();
Console.WriteLine("LENGTH OF 1ST LINE :" + length1);
// done with 1st part

//now do the same thing for 2nd line

Console.WriteLine("ENTER THE VALUES OF L2");
double length2 = L2.Length();
Console.WriteLine("LENGTH OF 2ND LINE :" + length2);

//TO CHECK LINE LENGTH IS EQUAL OR NOT USE SIMPLE IF STATEMENT


if(length1.Equals(length2))
{
    Console.WriteLine("Lengths L1 & L2 are equal");
}
else if (length1.CompareTo(length2)>0)
{
    Console.WriteLine("Length L1 is greater than L2");
}
else
{
    Console.WriteLine("Length L1 is less than L2");
}


