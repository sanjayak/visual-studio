using System;

struct RomanNumeral
{
    private int value;
    
    public RomanNumeral(int value)
    {
        this.value = value;
    }

    public static implicit operator RomanNumeral(int value)
    {
        return new RomanNumeral(value);
    }    
}