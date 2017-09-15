using System;
using System.Collections.Generic;
using System.Text;

namespace lab04-miya
{
    class Zoo
    {
    public string Africa
    {
        get; set;
    }
    public string NorthAmerica
    {
        get; set;
    }
    public string Asia
    {
        get; set;
    }
    public string Antarctica
    {
        get; set;
    }

    public Zoo(string continent)
    {
        Africa = continent;
    }
    public void Eat()
    {

    }
    public void Sleep()
    {

    }
    public bool IsPrey()
    {
        bool prey = true;
        return prey;
    }

}