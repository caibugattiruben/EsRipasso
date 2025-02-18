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
void vicini(int[,] m)
{
    int n = 0;
    int[,] p=new int[m.GetLength(0), m.GetLength(1)];
    
    //creo matrice 
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            //angoli
            if(i==0 && j == 0)
            {
                if (m[i + 1, j] == -1)
                {
                    n++;
                }
                if (m[i + 1, j+1] == -1)
                {
                    n++;
                }
                if (m[i , j+1] == -1)
                {
                    n++;
                }
            }
            else if(i==0&&j==m.GetLength(1)-1)
            {
                if (m[i + 1, j] == -1)
                {
                    n++;
                }
                if (m[i + 1, j - 1] == -1)
                {
                    n++;
                }
                if (m[i, j - 1] == -1)
                {
                    n++;
                }
            }
            else if (i == m.GetLength(0)-1 && j == 0)
            {
                if (m[i , j+1] == -1)
                {
                    n++;
                }
                if (m[i - 1, j + 1] == -1)
                {
                    n++;
                }
                if (m[i-1, j ] == -1)
                {
                    n++;
                }
            }
            else if (i == m.GetLength(0)-1 && j == m.GetLength(1)-1)
            {
                if (m[i - 1, j] == -1)
                {
                    n++;
                }
                if (m[i - 1, j - 1] == -1)
                {
                    n++;
                }
                if (m[i, j - 1] == -1)
                {
                    n++;
                }
            }
            //lati
            else if (i == 0   )
            {
                if (m[i , j+1] == -1)
                {
                    n++;
                }
                if (m[i , j - 1] == -1)
                {
                    n++;
                }
                if (m[i+1, j + 1] == -1)
                {
                    n++;
                }
                if (m[i+1, j - 1] == -1)
                {
                    n++;
                }
                if (m[i+1, j ] == -1)
                {
                    n++;
                }
            }
            else if(j == 0)
            {
                if (m[i+1, j ] == -1)
                {
                    n++;
                }
                if (m[i-1, j ] == -1)
                {
                    n++;
                }
                if (m[i + 1, j + 1] == -1)
                {
                    n++;
                }
                if (m[i - 1, j + 1] == -1)
                {
                    n++;
                }
                if (m[i , j+1] == -1)
                {
                    n++;
                }
            }
            else if (i == m.GetLength(0) - 1)
            {
                if (m[i, j + 1] == -1)
                {
                    n++;
                }
                if (m[i, j - 1] == -1)
                {
                    n++;
                }
                if (m[i - 1, j + 1] == -1)
                {
                    n++;
                }
                if (m[i - 1, j - 1] == -1)
                {
                    n++;
                }
                if (m[i - 1, j] == -1)
                {
                    n++;
                }
            }
            else if( j == m.GetLength(1)-1)
            {
                if (m[i+1, j ] == -1)
                {
                    n++;
                }
                if (m[i-1, j ] == -1)
                {
                    n++;
                }
                if (m[i + 1, j - 1] == -1)
                {
                    n++;
                }
                if (m[i - 1, j - 1] == -1)
                {
                    n++;
                }
                if (m[i , j-1] == -1)
                {
                    n++;
                }
            }
            //centro
            else
            {
                if (m[i + 1, j] == -1)
                {
                    n++;
                }
                if (m[i - 1, j] == -1)
                {
                    n++;
                }
                if (m[i , j + 1] == -1)
                {
                    n++;
                }
                if (m[i , j - 1] == -1)
                {
                    n++;
                }
                if (m[i+1, j + 1] == -1)
                {
                    n++;
                }
                if (m[i - 1, j-1] == -1)
                {
                    n++;
                }
                if (m[i - 1, j+1] == -1)
                {
                    n++;
                }
                if (m[i + 1, j-1] == -1)
                {
                    n++;
                }

            }
            if (m[i,j] != -1)
            {
                p[i, j] = n;
            }
            else
            {
                p[i, j] = -1;    
            }
           
            n = 0;
        }

    }
    dico(p);
}
int[,] matrice = new int[5, 5];
dico(matrice);
Console.WriteLine();
riempo(matrice);
Console.WriteLine();
dico(matrice);
Console.WriteLine();
vicini(matrice);
