

int[,] tablero = new int[5, 5];

void paso1()
{
    for (int f = 0; f < tablero.GetLength(0); f++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
            tablero[f, c] = 0;
                
                }
}

void paso2()
{
    tablero[4, 3] = 1;
    tablero[1, 1] = 1;
    tablero[2, 1] = 1;
    tablero[3, 4] = 1;

}

void paso3()
{
    string caracter_imprimir;
    for (int f = 0; f < tablero.GetLength(0); f++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
        {
           switch (tablero[f, c]){
                case 0:
                    caracter_imprimir = "";
                    break;
                case -1:
                    caracter_imprimir = "*";
                    break;
                case -2:
                    caracter_imprimir = "x";
                    break;
                default:
                    caracter_imprimir = "";
                    break;


            } 
            
       



            Console.Write(caracter_imprimir + "");
        }
        Console.WriteLine();
    }
}

void paso4()
{
    int fila, columna = 0;
    Console.Clear();
    do
    {
        Console.Write("ingrese fila");
        fila = Convert.ToInt32(Console.ReadLine());
        Console.Write("ingrese columna");
        columna = Convert.ToInt32(Console.ReadLine());

        if (tablero[fila, columna] == 1)
        {
            Console.Beep();
            tablero[fila, columna] = -1;

        }
        else
        {
            tablero[fila, columna] = -2;
        }
        Console.Clear();
        paso3();


    } while (true);
}

paso1();
paso2();
paso3();







