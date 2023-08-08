String imie = "Łukasz";
char plec = 'M';
int wiek = 17;
druk();
imie = "Ewa";
plec = 'K';
wiek = 33;
druk();
imie = "Łukasz";
plec = 'M';
wiek = 21;
druk();
imie = "Łukasz";
plec = 'K';
wiek = 72;
druk();
void druk()
{
    if (wiek < 30 && plec == 'K')
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else if (imie == "Ewa" && wiek == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (plec == 'M' && wiek < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else if (imie == "Łukasz" && plec == 'M' && wiek == 21)
    {
        Console.WriteLine("Mężczyzna pełnoletni o imieniu Łukasz mający 21 lat");
    }

    else if (wiek >= 65)
    {
        Console.WriteLine("Emeryt/ka");
    }
}