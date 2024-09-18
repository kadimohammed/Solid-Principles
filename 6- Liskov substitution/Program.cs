


using _6__Liskov_substitution.Before;

FixedDepositAccount fda = new FixedDepositAccount("kadi", 1000);
fda.Withdraw(500);
Console.WriteLine(fda);

/*
using _6__Liskov_substitution.After;

FixedDepositAccount fda = new FixedDepositAccount("kadi", 1000);
fda.Withdraw(500); // eror il pas accepter
Console.WriteLine(fda);
*/