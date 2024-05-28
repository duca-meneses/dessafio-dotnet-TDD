namespace DesafioTDD;
public class Calculadora
{
    private List<String> listaHistorico;
    private string data;

    public Calculadora(string data)
    {
        listaHistorico = new List<string>();
        this.data = data;
    }

    public int Somar(int num1, int num2)
    {
        int res = num1 + num2;
        listaHistorico.Insert(0, $"Historico\n{num1} + {num2} = {res}\n data:{data}");
        return res;
    }

    public int Subtrair(int num1, int num2)
    {
        int res = num1 - num2;
        listaHistorico.Insert(0, $"Historico\n{num1} - {num2} = {res}\n data:{data}");

        return res;
    }

    public int Mutiplicar(int num1, int num2)
    {
        int res = num1 * num2;
        listaHistorico.Insert(0, $"Historico\n {num1}  x  {num2}  =  {res} \n data: {data}");
        return res;
    }

    public int Dividir(int num1, int num2)
    {
        int res = num1 / num2;
        listaHistorico.Insert(0, $"Historico\n {num1}  /  {num2}  =  {res} \n data: {data}");
        return res;
    }

    public List<string> historico()
    {
        listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
        return listaHistorico;
    }
}
