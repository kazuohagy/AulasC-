// Tipo forte tem que falar qual é o tipo da variável
int b = 2;
int c = 2;

// Dois tipos de data type
// Value type (tipo valor)
// int, double, char
// Reference type (tipo referência)
// string, array, collection

// int[] a = new int[4];
// [1,2,3,4].CopyTo(a, 0);

class PrimeiraSechizada
{
    public int NumeroPessoas { get; set; }
    public int TempoDeTreinamento { get; set; }

    public PrimeiraSechizada(int parametro1, int parametro2)
    {
        NumeroPessoas = parametro1;
        TempoDeTreinamento = parametro2;
    }

    public int MostrarSechizada()
    {
        return NumeroPessoas * TempoDeTreinamento;
    }
}

class Program
{
    PrimeiraSechizada sechizada = new PrimeiraSechizada(10, 20);
     int planoId = 0;
}