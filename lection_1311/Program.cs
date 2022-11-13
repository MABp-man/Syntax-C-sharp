/////// работа с папками и файлами /////////

string path = "I:/MABp/Syntax-C-sharp/dz62";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();
for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}

///// РЕКУРСИЯ //////////////

Console.WriteLine(NumberRec(0, 10));
Console.WriteLine(SumRec(10));
Console.WriteLine(FactorialRec(10));
Console.WriteLine(PowerRec(2, 10));
Console.WriteLine(PowerMathRec(2, 10));
FindWords("асик", new char[1]);
CatalogInfo(path);
Towers();


/////// числа в строку от а до b //////

static string NumberRec(int a, int b)
    {
        if (a < b) return $"{a} " + NumberRec(a + 1, b);
        else return $"{b}";
    }

/////// Сумма от 1 до n //////////

static int SumRec(int n)
    {
        if (n == 1) return 1;
        else return n + SumRec(n - 1);
    }

/////// факториал числа n /////////

static int FactorialRec(int n)
    {
        if (n == 1) return 1;
        else return n * FactorialRec(n - 1);
    }


//////// возведение а в степень n //////////////

static int PowerRec(int a, int n)
    {
        if (n == 0) return 1;
        else return a * PowerRec(a, n-1);
        // return n == 0 ? 1 : a * PowerRec(a, n-1);
    }

static int PowerMathRec(int a, int n)
    {
        if (n == 0) return 1;
        else if(n % 2 == 0) return PowerRec(a * a, n/2);
        else return a * PowerRec(a, n-1);
        // return n == 0 ? 1 : a * PowerRec(a, n-1);
    }

/////// перебор слов /////////

static void FindWords(string alphabet, char[] word, int length = 0)
    {
        if (length == word.Length)
        {    
            Console.WriteLine(new String(word));
            return;
        }
        for (int i = 0; i < alphabet.Length; i++)
        {
            word[length] = alphabet[i];
            FindWords(alphabet, word, length + 1);
        }
    }

/////// работа с папками и файлами. рекурсия /////////////

static void CatalogInfo(string path, string indent = "")
    {
        DirectoryInfo catalog = new DirectoryInfo(path);
        
        DirectoryInfo[] catalogs = catalog.GetDirectories();
        for (int i = 0; i < catalogs.Length; i++)
        {
            Console.WriteLine($"{indent}{catalogs[i].Name}");
            CatalogInfo(catalogs[i].FullName, indent + "  ");
        }
        FileInfo[] files = catalog.GetFiles();
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine($"{indent}{files[i].Name}");
        }
    }
/////// игра в три пирамидки //////////

static void Towers(string with = "1", string to = "3", string help = "2", int count = 2)
    {
        if (count > 1) Towers(with, help, to, count - 1);
        Console.WriteLine($"{with} >> {to}");
        if (count > 1) Towers(help, to, with, count - 1);
    }

/////// обход структуры математического дерева ////////

string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                 0    1    2     3    4    5    6    7    8    9    10   11
InOrderTraversal(1, tree);

static void InOrderTraversal(int pos, string[] tree)
    {
         if (pos < tree.Length)
             {
                 int left = 2 * pos;
                 int right = 2 * pos + 1;
                 if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left, tree);
                 Console.Write($"{tree[pos]} ");
                 if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right, tree);
             }
    }

/////////////////