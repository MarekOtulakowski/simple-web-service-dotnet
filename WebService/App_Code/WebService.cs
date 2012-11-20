using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "makoff.webService")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod(Description = "Funkcja dodawania, poprawne wywołanie Dodaj(int x, int y)" +
                             "<br />" +
                             "Zwraca int jako wynik, liczba całkowita")]
    public int Dodaj(int x, int y)
    {
        return x + y;
    }

    [WebMethod(Description = "Funkcja odejmowania, poprawne wywołanie Odejmij(int x, int y)" +
                             "<br />" +
                             "Zwraca int jako wynik, liczba całkowita")]
    public int Odejmij(int x, int y)
    {
        return x - y;
    }

    [WebMethod(Description = "Funkcja mnożenia, poprawne wywołanie Pomnoz(int x, int y)" +
                             "<br />" +
                             "Zwraca int jako wynik, liczba całkowita")]
    public int Pomnoz(int x, int y)
    {
        return x * y;
    }

    [WebMethod(Description = "Funkcja dzielenia, poprawne wywołanie Podziel(int x, int y)" +
                             "<br />" +
                             "Zwraca int jako wynik, liczba całkowita")]
    public int Podziel(int x, int y)
    {
        if (y == 0)
        {
            throw new Exception("nie można dzielić przez zero!");
        }

        return x / y;
    }
    
}
