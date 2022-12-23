using System;
// write in 2019 by maurizio.conti@fablabromagna.org

public static class Alfabeto
{
    public static bool Verifica(string input)
    {
        string alfabeto = "abcdefghijklmnopqrstuvzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        char i='a'; 
        bool c=false;
        for(int k=0; k<alfabeto.Length; k++)
        {
            if(i==alfabeto[k])
            {
               c=true;
               break;  
            }
            else
            {
                c=false;
            }
        }

        return c;
    }
}
