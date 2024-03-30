int GetNumber(string message){
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int baseNum = GetNumber("Insert a base: ");
int powerNum = GetNumber("Insert a power: ");
int multRes = 1;

for (int i = 1; i <= powerNum; i++){
   multRes *= baseNum;
}

Console.WriteLine($"{baseNum}, {powerNum} -> {multRes}");