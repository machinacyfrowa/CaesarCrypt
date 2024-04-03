//funkcja wykonuje "przesunięcie" znaku "c" według tablicy ASCII o określoną ilość znaków "offset" oraz zwraca nowy znak
char ASCIIShift(char c, int offset)
{
    //sprawdz czy znak który chcemy kodować jest wielką literą. jeśli nie to go pomiń
    if((int)c < 65 || (int)c > 90)
    {
        //nieprawidłowy znak, zwróc spacje
        return ' ';
    }
    //"wyciągnij" kod ascii znaku "c" i zapisz go do zmiennej ASCIICode
    int ASCIICode = (int)c;
    //"przesun" poprzed dodanie wartosci offset do kodu znaku
    ASCIICode += offset;
    //jeżeli wyzliśmy poza zakres
    if(ASCIICode > 90)
    {
        //odejmij 26 zeby wrocic na początek
        ASCIICode -= 26;
    }
    //kod zamieniamy na znak
    c = (char)ASCIICode;
    //zwracamy przesunięty znak
    return c;
}

string ASCIICaesar(string text, int offset)
{
    text = text.ToUpper();
    string encodedText = "";
    foreach (char c in text)
    {
        encodedText += ASCIIShift(c, offset);
    }
    return encodedText;
}

//zapytaj użytkownika o tekst
Console.WriteLine("Podaj tekst do zakodowania: ");
//pobierz to co napisze - zamień null na "A"
string input = Console.ReadLine() ?? "";
string pureText = input;
//zapytaj o przesunięcie
Console.WriteLine("Podaj wartość przesunięcia: ");
//wczytaj wartośc - zamień null na "0"
input = Console.ReadLine() ?? "0";
//skonwertuj string -> int
int offset = int.Parse(input);

//użyj funkcji
string result = ASCIICaesar(pureText, offset);
Console.WriteLine("Tekst po zakodowaniu: " +  result);
