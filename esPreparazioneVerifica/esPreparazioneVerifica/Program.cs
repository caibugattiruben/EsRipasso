void riempo(int[,] m)
{
    int n = 0;
    Random rdn=new Random();
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            if (n < 5)
            {
                m[i, j] = rdn.Next(-1, 1);
                
                if (m[i, j] == -1)
                {
                    n++;
                }
            }
            else
            {
                m[i, j]=0;
            }
        }
        
    }
}
void dico(int[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            Console.Write("["+m[i, j]+"]");
        }
        Console.WriteLine();
    }
}
int[,] matrice = new int[5, 5];
dico(matrice);
Console.WriteLine();
riempo(matrice);
Console.WriteLine();
dico(matrice);
