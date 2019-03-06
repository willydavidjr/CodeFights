using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CFTheCore
{

    class Program2
    {

        #region data
        protected enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear };
        protected class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int ID { get; set; }
            public GradeLevel Year;
            public List<int> ExamScores;
        }

        protected static List<Student> students = new List<Student>
        {
            new Student {FirstName = "Terry", LastName = "Adams", ID = 120,
                Year = GradeLevel.SecondYear,
                ExamScores = new List<int>{ 99, 82, 81, 79}},
            new Student {FirstName = "Terry1", LastName = "Adams", ID = 120,
                Year = GradeLevel.SecondYear,
                ExamScores = new List<int>{ 99, 82, 81, 79}},
            new Student {FirstName = "Fadi", LastName = "Fakhouri", ID = 116,
                Year = GradeLevel.ThirdYear,
                ExamScores = new List<int>{ 99, 86, 90, 94}},
            new Student {FirstName = "Hanying", LastName = "Feng", ID = 117,
                Year = GradeLevel.FirstYear,
                ExamScores = new List<int>{ 93, 92, 80, 87}},
            new Student {FirstName = "Cesar", LastName = "Garcia", ID = 114,
                Year = GradeLevel.FourthYear,
                ExamScores = new List<int>{ 97, 89, 85, 82}},
            new Student {FirstName = "Debra", LastName = "Garcia", ID = 115,
                Year = GradeLevel.ThirdYear,
                ExamScores = new List<int>{ 35, 72, 91, 70}},
            new Student {FirstName = "Hugo", LastName = "Garcia", ID = 118,
                Year = GradeLevel.SecondYear,
                ExamScores = new List<int>{ 92, 90, 83, 78}},
            new Student {FirstName = "Sven", LastName = "Mortensen", ID = 113,
                Year = GradeLevel.FirstYear,
                ExamScores = new List<int>{ 88, 94, 65, 91}},
            new Student {FirstName = "Claire", LastName = "O'Donnell", ID = 112,
                Year = GradeLevel.FourthYear,
                ExamScores = new List<int>{ 75, 84, 91, 39}},
            new Student {FirstName = "Svetlana", LastName = "Omelchenko", ID = 111,
                Year = GradeLevel.SecondYear,
                ExamScores = new List<int>{ 97, 92, 81, 60}},
            new Student {FirstName = "Lance", LastName = "Tucker", ID = 119,
                Year = GradeLevel.ThirdYear,
                ExamScores = new List<int>{ 68, 79, 88, 92}},
            new Student {FirstName = "Michael", LastName = "Tucker", ID = 122,
                Year = GradeLevel.FirstYear,
                ExamScores = new List<int>{ 94, 92, 91, 91}},
            new Student {FirstName = "Eugene", LastName = "Zabokritski", ID = 121,
                Year = GradeLevel.FourthYear,
                ExamScores = new List<int>{ 96, 85, 91, 60}}
        };
        #endregion

        static int Sum(int i, int j)
        {
            return i + j;
        }
        public static void GroupBySingleProperty()
        {
            Console.WriteLine("Group by a single property in an object:");

            // Variable queryLastNames is an IEnumerable<IGrouping<string, 
            // DataClass.Student>>. 
            var queryLastNames =
                from student in students
                group student by student.LastName into newGroup
                orderby newGroup.Key
                select newGroup;

            var exam = students.GroupBy(w => w.LastName).Select(c => new List<Student>(c.Take(1))).ToList();

            foreach (var nameGroup in queryLastNames)
            {
                Console.WriteLine($"Key: {nameGroup.Key}");
                foreach (var student in nameGroup)
                {
                    Console.WriteLine($"\t{student.LastName}, {student.FirstName}");
                }
            }
        }

        static void Main(string[] args)
        {

            var result = fibonacciIndex(1);

            #region Test Method for Functions
            /*
            
            string name = null;

            string clientName = name ?? "John Doe";

            var result = findMode(new int[] { 1, 1, 1, 2, 3, 2, 2, 2 });
            Console.WriteLine(clientName);  
             
            string interPo = "";
            Console.WriteLine($"Male: {(int)Gender.Male} {interPo}");

            int[] xArray = new int[] { 1 };
            char ch = '7';
            int chInt = (int)ch;
            double x = 100000.2333;
            string y = string.Empty;
            y = string.Format(System.Globalization.CultureInfo.GetCultureInfo("de-DE"), "{0:#,##0.##}", x);

            //BigInteger x = 2354.44;
            var res = (int)Math.Round(0.99, 2, MidpointRounding.AwayFromZero);
            var extra = extraCreditAssignment("66.(6)", 9);
            //GroupBySingleProperty();
            int[][] input = new int[4][];
            input[0] = new int[] { 1, 1, 1, 2 };
            input[1] = new int[] { 1, 7, 1, 2 };
            input[2] = new int[] { 1, 1, 1, 2 };
            input[3] = new int[] { 1, 2, 1, 5 };

            int[][] result = boxBlur(input);

            string[] counting = productionSeriesInfo(200, 10, 20, new int[] { 2, 1, 2, 2, 2, 2, 2, 1, 2, 2 });

            string greedy = greedyDecoding1("201001292002626");

            bool[][] arr = new bool[3][];
            arr[0] = new bool[] { true, false, false };
            arr[1] = new bool[] { false, true, false };
            arr[2] = new bool[] { false, false, false };
            //arr[2] = new bool[] { false, false, false };

            int[][] mines = minesweeper(arr);

            //int intClass = takingAttendance(new string[] { "Ashley", "Robert", "Miles", "Archibald", "Taylor", "Vanessa", "Isaac" });

            int[][] scoring = new int[3][];
            scoring[0] = new int[] { 9, 8, 10, 9 };
            scoring[1] = new int[] { 4, 3, 3, 3 };
            scoring[2] = new int[] { 70, 99, 100, 99, 98, 99, 99 };
            var classResult = finalSlacker(new int[] { 0, 1, 99 }, scoring);


            var matr = new int[3][];
            matr[0] = new int[] { 1, 0, 0, 2 };
            matr[1] = new int[] { 0, 5, 0, 1 };
            matr[2] = new int[] { 0, 0, 3, 5 };

            //int[] col = new 
            var matrResult = constructSubmatrix(matr, new int[] { 1 }, new int[] { 0, 2 });
            var rr = decodeString2("100[codesignal]");

            //var zig = zigzag(new int[] { 9, 8, 8, 5, 3, 5, 3, 2, 8, 6 });

            var alternating = constructArray(7);
            var alpha = newNumeralSystem('C');

            var jimmy = jumpingJimmy(new int[] { 5, 1, 8, 2, 4, 3, 1, 9, 8, 5, 1 }, 1);

            var keykey = digitRootSort(new int[] { 100, 22, 4, 11, 31, 103 });

            var alphachange = alphabeticShift("abcde");

            var chess = chessBoardCellColor("A1", "B2");

            var reverse = reverseInterference("ABEIO", "DGHKN", "BGBBB", "BBBBB");

            var periodic = periodicSequence(1, 2, 3, 5);
            */
            #endregion
        }



        static int fibonacciIndex(int n)
        {
            int[] w = new int[] { 1, 7, 12, 17, 26 };
            return w[n - 1];
        }


        static int findMode(int[] intArr)
        {
            var res = intArr.GroupBy(w => w).ToDictionary(x => x, x => x.Count()).OrderByDescending(z => z.Value).Take(1)
                .Select(d => d.Key).FirstOrDefault();

            Dictionary<int, int> dic = new Dictionary<int, int>();
            int key = dic.Where(kvp => kvp.Value == 1).Select(kvp => kvp.Key).FirstOrDefault();

            int res1 = dic.OrderByDescending(z => z.Value).Take(1)
                .Select(d => d.Key).FirstOrDefault();

            return 0;
        }
            

        static int[][] boxBlur(int[][] image)
        {
            var howmanycount = image[0].Count() - 2;
            var howmanyloop = image.Count() - 2;
            int counter = 0;
            int[][] result = new int[howmanyloop][];


            for (int a = 0; a < howmanyloop; a++)
            {
                List<int> average = new List<int>();
                for (int x = 0; x < howmanycount; x++)
                {
                    List<int> lstResult = new List<int>();
                    for (int y = 0; y < 3; y++)
                    {
                        for (int z = 0; z < 3; z++)
                        {
                            lstResult.Add(image[y + a][z + x]);
                        }
                    }
                    var res = (int)Math.Floor(lstResult.Average());
                    average.Add(res);
                }
                result[a] = average.ToArray();
            }

            return result;
        }

        static string[] productionSeriesInfo(int ingredients, int recipe1, int recipe2, int[] productionSeries)
        {
            int intFinalCount = 0;
            foreach (var item in productionSeries)
            {
                if (item == 1)
                {
                    intFinalCount += recipe1;
                }
                else if (item == 2)
                {
                    intFinalCount += recipe2;
                }
                else
                {
                    intFinalCount += item;
                }
            }
            return ingredients / intFinalCount == 1 && ingredients % intFinalCount == 0 ? new string[] { "Ok" }
            : intFinalCount > ingredients ? new string[] { "Out of ingredients!", $"Missing {intFinalCount - ingredients} ingredients" }
            : new string[] { "Ok", $"Ingredients for {(ingredients / intFinalCount) - 1} more series" };
        }

        /*
        string rome(int n)
        {
            if ((n < 0) || (n > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (n < 1) return string.Empty;
            if (n >= 1000) return "M" + rome(n - 1000);
            if (n >= 900) return "CM" + rome(n - 900);
            if (n >= 500) return "D" + rome(n - 500);
            if (n >= 400) return "CD" + rome(n - 400);
            if (n >= 100) return "C" + rome(n - 100);
            if (n >= 90) return "XC" + rome(n - 90);
            if (n >= 50) return "L" + rome(n - 50);
            if (n >= 40) return "XL" + rome(n - 40);
            if (n >= 10) return "X" + rome(n - 10);
            if (n >= 9) return "IX" + rome(n - 9);
            if (n >= 5) return "V" + rome(n - 5);
            if (n >= 4) return "IV" + rome(n - 4);
            if (n >= 1) return "I" + rome(n - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }
        */


        string rome(int n)
        =>

            n < 1 ? string.Empty :
            n >= 1000 ? "M" + rome(n - 1000) :
            n >= 900 ? "CM" + rome(n - 900) :
            n >= 500 ? "D" + rome(n - 500) :
            n >= 400 ? "CD" + rome(n - 400) :
            n >= 100 ? "C" + rome(n - 100) :
            n >= 90 ? "XC" + rome(n - 90) :
            n >= 50 ? "L" + rome(n - 50) :
            n >= 40 ? "XL" + rome(n - 40) :
            n >= 10 ? "X" + rome(n - 10) :
            n >= 9 ? "IX" + rome(n - 9) :
            n >= 5 ? "V" + rome(n - 5) :
            n >= 4 ? "IV" + rome(n - 4) :
            "I" + rome(n - 1);

        static int[] arrayReplace(int[] inputArray, int elemToReplace, int substitutionElem)
        {
            List<int> lst = new List<int>();
            foreach (var item in inputArray)
            {
                if (elemToReplace == item)
                    lst.Add(substitutionElem);
                else
                    lst.Add(item);
            }
            return lst.ToArray();
        }

        static int[][] constructSubmatrix(int[][] matrix, int[] rowsToDelete, int[] columnsToDelete)
        {
            List<List<int>> result = new List<List<int>>();

            for (int x = 0; x < matrix.Count(); x++)
            {
                if (!rowsToDelete.Any(w => w == x))
                {
                    List<int> initial = new List<int>();
                    for (int y = 0; y < matrix[x].Count(); y++)
                    {
                        if (!columnsToDelete.Any(w => w == y))
                        {

                            initial.Add(matrix[x][y]);
                        }

                    }
                    result.Add(initial);
                }
            }

            int[][] resulting = new int[result.Count()][];
            for (int z = 0; z < result.Count(); z++)
            {
                resulting[z] = result[z].ToArray();
            }
            return resulting;
        }

        static string decodeString(string s)
        {
            StringBuilder sb = new StringBuilder();
            List<string> lst = new List<string>();
            string strTest = @"z1[y]zzz2[abc]";
            while (!string.IsNullOrEmpty(strTest))
            {

                Regex regex = new Regex(@"\d\[[\w]*\]");
                Match match = regex.Match(strTest);
                if (match.Success)
                {
                    var resu = strTest.IndexOf(match.Value);
                    lst.Add(match.Value);
                    strTest = strTest.Remove(resu, match.Value.Length);
                }
            }

            string strPrevious = "";
            string strFinal = "";

            for (int x = 0; x < lst.Count(); x++)
            {
                Regex regex = new Regex(@"\d\[[\w]*\]");
                Match match = regex.Match(lst[x]);
                if (match.Success)
                {

                    //var resu = lst[x].IndexOf(match.Value);
                    //sb.Append(lst[x].Substring(0, resu));
                    //var stToRpeat = lst[x].Substring(resu + 2, (lst[x].Length - resu) - 3);
                    var en = Enumerable.Repeat(lst[x].Substring(2, lst[x].Length - 3) + strPrevious, (int)char.GetNumericValue(match.Value[0]));

                    if (x <= 1)
                        return (string.Join("", en.SelectMany(w => w)));

                    strFinal = strPrevious + (string.Join("", en.SelectMany(w => w)));
                    strPrevious = strFinal;
                }
            }

            return "";
        }

        static string decodeString1(string s)
        {
            StringBuilder sb = new StringBuilder();
            List<string> lst = new List<string>();
            string strTest = @"2[b3[aeweq]]";
            while (!string.IsNullOrEmpty(strTest))
            {
                int y = strTest.IndexOf('[');
                bool chk = checkIfSquare(strTest.Substring(y + 1));

            }

            string strPrevious = "";
            string strFinal = "";

            for (int x = 0; x < lst.Count(); x++)
            {
                Regex regex = new Regex(@"\d\[[\w]*\]");
                Match match = regex.Match(lst[x]);
                if (match.Success)
                {

                    //var resu = lst[x].IndexOf(match.Value);
                    //sb.Append(lst[x].Substring(0, resu));
                    //var stToRpeat = lst[x].Substring(resu + 2, (lst[x].Length - resu) - 3);
                    var en = Enumerable.Repeat(lst[x].Substring(2, lst[x].Length - 3) + strPrevious, (int)char.GetNumericValue(match.Value[0]));

                    if (x <= 1)
                        return (string.Join("", en.SelectMany(w => w)));

                    strFinal = strPrevious + (string.Join("", en.SelectMany(w => w)));
                    strPrevious = strFinal;
                }
            }

            return "";
        }

        static string decodeString2(string s)
        {
            var stackCount = new Stack<int>();
            var result = new Stack<string>();
            int intCount = 0;
            result.Push("");
            while (intCount < s.Count())
            {
                char chrCheck = s[intCount];
                if (chrCheck >= '0' && chrCheck <= '9')
                {
                    int start = intCount;
                    while (s[intCount + 1] >= '0' && s[intCount + 1] <= '9')
                        intCount++;
                    stackCount.Push(int.Parse(s.Substring(start, fncCheckHowManyNumbers(s.Substring(start)))));
                }
                else if (chrCheck == '[')
                    result.Push("");
                else if (chrCheck == ']')
                {
                    String strRepeat = result.Pop();
                    StringBuilder sb = new StringBuilder();
                    int times = stackCount.Pop();
                    for (int w = 0; w < times; w++)
                    {
                        sb.Append(strRepeat);
                    }
                    result.Push(result.Pop() + sb);
                }
                else
                    result.Push(result.Pop() + chrCheck);
                intCount++;
            }
            return result.Pop();
        }

        static int fncCheckHowManyNumbers(string s)
        {
            int intCount = 0;
            foreach (var item in s)
            {
                if (char.IsNumber(item))
                    intCount++;
                else
                    return intCount;
            }
            return intCount;
        }

        static bool checkIfSquare(string s)
        {
            foreach (var item in s)
            {
                if (item == '[')
                    return true;
                else
                    return false;
            }
            return false;
        }

        static string greedyDecoding(string message)
        {
            List<char> lstReturn = new List<char>()
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G',
                'H', 'I', 'J', 'K', 'L', 'M', 'N',
                'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
            };
            List<char> result = new List<char>();
            for (int x = 0; x < message.ToCharArray().Length; x++)
            {
                string vv = message[x].ToString();
                if ((x + 1) == message.ToCharArray().Length)
                {

                    string a = message[x].ToString();

                    int c = int.Parse(a);
                    if (c == 0)
                        return string.Join("", result);
                    result.Add(lstReturn[c - 1]);
                    return string.Join("", result);
                }
                string tt = message[x].ToString() + message[x + 1].ToString();
                int temporary = int.Parse(tt);
                if (temporary > 9 && temporary < 27)
                {
                    result.Add(lstReturn[temporary - 1]);
                    x++;
                }
                else
                {
                    string a = message[x].ToString();

                    int c = int.Parse(a);
                    if (c != 0)
                    {
                        if (int.Parse(message[x].ToString()) == 0)
                        {
                            x++;
                        }
                        result.Add(lstReturn[c - 1]);
                    }

                }
            }
            return string.Join("", result);
        }

        static string greedyDecoding1(string message)
        {
            if (string.IsNullOrEmpty(message))
                return string.Empty;

            List<char> lstReturn = new List<char>()
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G',
                'H', 'I', 'J', 'K', 'L', 'M', 'N',
                'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
            };
            List<int> result = new List<int>();
            StringBuilder sb = new StringBuilder();

            var len = message.ToCharArray().Length;
            //int eee = int.Parse(message);

            for (int x = 0; x < len; x++)
            {
                if ((x + 1) == len)
                {

                    string a = message[x].ToString();

                    int c = int.Parse(a);
                    if (c == 0)
                        return sb.ToString();
                    sb.Append(lstReturn[c - 1]);
                    break;
                }

                int temporary = int.Parse(message[x].ToString() + message[x + 1].ToString());

                if (temporary == 0)
                {
                    x++;
                    continue;
                }

                if (temporary > 9 && temporary < 27)
                {
                    sb.Append(lstReturn[temporary - 1]);
                    x++;
                }
                else
                {

                    if (int.Parse(message[x].ToString()) == 0)
                    {
                        sb.Append(lstReturn[temporary - 1]);
                        x++;
                    }
                    else
                    {
                        sb.Append(lstReturn[int.Parse(message[x].ToString()) - 1]);
                    }
                }
            }

            return sb.ToString();
        }

        /*
        static int[][] minesweeper(bool[][] matrix)
        {

            int[][] result = new int[matrix.Count()][];

            //If no item, return nothing
            if (matrix.Count() < 1 && matrix[0].Count() < 1)
                return null;

            //Check if one item only
            if (matrix.Count() == 1 && matrix[0].Count() == 1)
            {
                result[0] = new int[] { matrix[0][0] == true ? 1 : 0 };
                return result;
            }

            //Check if this is matrix argument is one liner only
            if (matrix.Count() == 1 && matrix[0].Count() > 1)
            {
                
                List<int> lst = new List<int>();

                for (int y = 0; y < matrix[0].Count(); y++)
                {
                    List<bool> bools = new List<bool>();
                    //Left edge
                    if (y == 0)
                    {
                        bools.Add(matrix[0][y + 1]);
                        lst.Add(bools.Count(w => w));
                        result[0] = lst.ToArray();
                        continue;
                    }

                    //Right edge
                    if (y == (matrix[0].Count() -1))
                    {
                        bools.Add(matrix[0][y - 1]);
                        lst.Add(bools.Count(w => w));
                        result[0] = lst.ToArray();
                        continue;
                    }

                    bools.Add(matrix[0][y - 1]);
                    bools.Add(matrix[0][y + 1]);
                    result[0] = lst.ToArray();
                }

                return result;
            }

            //Check if one vertical only
            if (matrix[0].Count() == 1 && matrix.Count() > 1)
            {
                for (int y = 0; y < matrix.Count(); y++)
                {
                    List<int> lst = new List<int>();

                    List<bool> bools = new List<bool>();
                    //Up edge
                    if (y == 0)
                    {
                        bools.Add(matrix[y + 1][0]);
                        lst.Add(bools.Count(w => w));
                        result[y] = lst.ToArray();
                        continue;
                    }

                    //Down edge
                    if (y == (matrix.Count() - 1))
                    {
                        bools.Add(matrix[y - 1][0]);
                        lst.Add(bools.Count(w => w));
                        result[y] = lst.ToArray();
                        continue;
                    }

                    bools.Add(matrix[y - 1][0]);
                    bools.Add(matrix[y + 1][0]);
                    result[0] = lst.ToArray();
                }

                return result;
            }

            for (int x = 0; x < matrix.Count(); x++)
            {
                List<int> lst = new List<int>();
                for (int y = 0; y < matrix[x].Count(); y++)
                {
                    //if (matrix[x][y] == true)
                    //{
                    //    lst.Add(1);
                    //    continue;
                    //}

                    List<bool> bools = new List<bool>();

                    //Condition for upper left edge (0,0)
                    if (x == 0 && y ==0)
                    {
                        bools.Add(matrix[x + 1][y]);
                        bools.Add(matrix[x + 1][y + 1]);
                        bools.Add(matrix[x][y + 1]);
                        lst.Add(bools.Count(w => w));
                        continue;
                        
                    }

                    //Condition for upper right edge (0, maxLength)
                    if (x ==0 && y == matrix[x].Count() - 1)
                    {
                        bools.Add(matrix[x][y - 1]);
                        bools.Add(matrix[x + 1][y - 1]);
                        bools.Add(matrix[x + 1][y]);
                        lst.Add(bools.Count(w => w));
                        continue;
                    }

                    //Condition for lower left edge (maxLength, 0)
                    if (x == matrix.Count() - 1 && y == 0)
                    {
                        bools.Add(matrix[x -1][y]);
                        bools.Add(matrix[x - 1][y + 1]);
                        bools.Add(matrix[x][y + 1]);
                        lst.Add(bools.Count(w => w));
                        continue;
                    }

                    //Condition for the lower right edge(maxLength, maxLength)
                    if ((x == matrix.Count() - 1) && (y == matrix[x].Count() -1))
                    {
                        bools.Add(matrix[x][y - 1]);
                        bools.Add(matrix[x - 1][y - 1]);
                        bools.Add(matrix[x][y - 1]);
                        lst.Add(bools.Count(w => w));
                        continue;
                    }

                    //Condition for upper section
                    if (x == 0 && y > 0)
                    {
                        bools.Add(matrix[x][y - 1]);
                        bools.Add(matrix[x + 1][y - 1]);
                        bools.Add(matrix[x + 1][y]);
                        bools.Add(matrix[x + 1][y + 1]);
                        bools.Add(matrix[x][y + 1]);
                        lst.Add(bools.Count(w => w));
                        continue;
                    }

                    //Condition for left section
                    if (y == 0 && x > 0)
                    {
                        bools.Add(matrix[x - 1][y]);
                        bools.Add(matrix[x - 1][y + 1]);
                        bools.Add(matrix[x][y + 1]);
                        bools.Add(matrix[x + 1][y + 1]);
                        bools.Add(matrix[x + 1][y]);
                        lst.Add(bools.Count(w => w));
                        continue;
                    }

                    //Condition for right section
                    if ((y == matrix[x].Count() - 1) && x > 0)
                    {
                        bools.Add(matrix[x - 1][y]);
                        bools.Add(matrix[x - 1][y - 1]);
                        bools.Add(matrix[x][y - 1]);
                        bools.Add(matrix[x + 1][y - 1]);
                        bools.Add(matrix[x + 1][y]);
                        lst.Add(bools.Count(w => w));
                        continue;
                    }

                    //Condition for down section
                    if((x == matrix.Count() - 1) && y > 0)
                    {
                        bools.Add(matrix[x][y - 1]);
                        bools.Add(matrix[x - 1][y - 1]);
                        bools.Add(matrix[x - 1][y]);
                        bools.Add(matrix[x - 1][y + 1]);
                        bools.Add(matrix[x][y + 1]);
                        lst.Add(bools.Count(w => w));
                        continue;
                    }

                    {
                        bools.Add(matrix[x - 1][y]);
                        bools.Add(matrix[x - 1][y - 1]);
                        bools.Add(matrix[x - 1][y + 1]);
                    }
                    {
                        bools.Add(matrix[x][y - 1]);
                    }
                    {
                        bools.Add(matrix[x][y + 1]);
                    }
                    {
                        bools.Add(matrix[x + 1][y]);
                        bools.Add(matrix[x + 1][y - 1]);
                        bools.Add(matrix[x + 1][y + 1]);
                    }
                    lst.Add(bools.Count(w => w));
                }

                result[x] = lst.ToArray();
            }

            return result;
        }

        */

        static int[][] minesweeper(bool[][] matrix)
        {
            bool[][] result = new bool[matrix.Count() + 2][];

            List<bool> cover = new List<bool>();
            cover.AddRange(Enumerable.Repeat(false, matrix[0].Length + 2));

            result[0] = cover.ToArray();
            result[result.Count() - 1] = cover.ToArray();


            for (var x = 1; x < result.Count() - 1; x++)
            {
                List<bool> zero = new List<bool>();
                zero.Add(false);
                zero.AddRange(matrix[x - 1]);
                zero.Add(false);

                result[x] = zero.ToArray();
            }


            int[][] final = new int[matrix.Count()][];

            for (int c = 1; c < result.Count() - 1; c++)
            {
                List<int> lst = new List<int>();
                for (int y = 1; y < result[c].Length - 1; y++)
                {
                    List<bool> bools = new List<bool>();
                    {
                        bools.Add(result[c - 1][y]);
                        bools.Add(result[c - 1][y - 1]);
                        bools.Add(result[c - 1][y + 1]);
                    }
                    {
                        bools.Add(result[c][y - 1]);
                    }
                    {
                        bools.Add(result[c][y + 1]);
                    }
                    {
                        bools.Add(result[c + 1][y]);
                        bools.Add(result[c + 1][y - 1]);
                        bools.Add(result[c + 1][y + 1]);
                    }
                    lst.Add(bools.Count(w => w));
                }
                final[c - 1] = lst.ToArray();
            }
            return final;
        }

        static int takingAttendance(string[] classList)
        {
            List<int> finalCount = new List<int>();
            int counting = 0;
            List<string> vowels = new List<string>()
            {
                "A"
            };
            foreach (var item in classList)
            {
                //char[] chArray = item.ToCharArray();

                //var result = item.Split()
                //foreach (var item2 in chArray)
                //{
                //    //if ()
                //}
                var res = item.ToLower()
                     .Replace("a", "#")
                     .Replace("e", "#")
                     .Replace("i", "#")
                     .Replace("o", "#")
                     .Replace("u", "#")
                     .Replace("y", "#")
                     .Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);

                res.ToList().ForEach(x =>
                        {
                            double finalCountToAdd = 1;
                            finalCountToAdd = Math.Pow(2, (double)x.Count() - 1);
                            counting += (int)finalCountToAdd;
                            //return null;
                        }
                    );
                counting += 5;

                //.Select(i => new string(i.ToCharArray().OrderBy(x => x).ToArray()))
                //.Aggregate((a, b) => a + b);

                //string input = "alkjihgefdcb";

                //var input1 = input
                // .Replace("a", "#a")
                // .Replace("e", "#e")
                // .Replace("i", "#i")
                // .Replace("o", "#u")
                // .Replace("u", "#u")
                // .Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
                //.Select(i => new string(i.ToCharArray().OrderBy(x => x).ToArray()))
                //.Aggregate((a, b) => a + b);
            }
            return counting;
        }

        static int extraCreditAssignment(string deci, int denominator)
        {
            //var value = deci.IndexOf('(', deci.LastIndexOf(')'));
            //var x = Enumerable.Repeat(value, 2);
            //deci = deci.Replace(")", "");
            //deci = deci.Replace("(", "");
            //var converted = Convert.ToDecimal(deci + x);
            //var multiplied = denominator * converted;
            //return (int)Math.Round((denominator * multiplied));
            //(int)Math.Floor((denominator * Convert.ToDecimal(deci)));
            return 0;
        }

        static int finalSlacker(int[] weights, int[][] scores)
        {
            double checkGradeLetter = 0;


            var x = (double)scores[0].Sum() / (double)(scores[0].Count() * 10);
            var y = (double)scores[1].Sum() / (double)(scores[1].Count() * 5);
            var z = (double)scores[2].Sum() / (double)(scores[2].Count() * 100);
            checkGradeLetter = ((x + y + z) / 3) * 100;
            int whattouse = 0;
            if (checkGradeLetter >= 95)
                whattouse = 90;
            else if (checkGradeLetter < 95 && checkGradeLetter >= 90)
                whattouse = 100;
            else if (checkGradeLetter < 90 && checkGradeLetter >= 85)
                whattouse = 80;
            else if (checkGradeLetter < 85 && checkGradeLetter >= 80)
                whattouse = 90;
            else if (checkGradeLetter < 80 && checkGradeLetter >= 75)
                whattouse = 70;
            else if (checkGradeLetter < 75 && checkGradeLetter >= 70)
                whattouse = 80;
            else if (checkGradeLetter < 70 && checkGradeLetter >= 65)
                whattouse = 60;
            else if (checkGradeLetter < 65 && checkGradeLetter >= 60)
                whattouse = 70;
            else if (checkGradeLetter < 60 && checkGradeLetter >= 30)
                whattouse = 0;
            else
                whattouse = 60;

            var mustScore = 90 - ((x * weights[0]) + (y * weights[1]));
            var left = (((scores[2].Count() + 1)) * 100) * mustScore;
            var left2 = left - (double)(scores[2].Sum() * weights[2]);
            double final = (double)left2 / (double)weights[2];
            return final > 0 ? (int)Math.Ceiling(final) : 0;
        }

        static int[] changeRoot(int[] parent, int newRoot)
        {

            return null;
        }

        static int zigzag(int[] a)
        {
            int intCount = 0;
            int intMax = 0;
            List<int> lstUp = new List<int>();
            lstUp = a.ToList();

            List<int> lstDown = new List<int>();
            lstDown = a.ToList();
            while (lstUp.Count() > 0)
            {

                if ((intMax == lstUp.Count() - 1) || (intCount == lstUp.Count() - 1))
                    break;

                string increase = "up";
                int index = 0;
                for (int x = 0; x < lstUp.Count() - 1; x++)
                {
                    if (lstUp[x] == lstUp[x + 1])
                    {
                        index++;
                        lstUp.RemoveRange(x, index);
                        break;
                    }

                    if (increase == "up")
                    {
                        if (lstUp[x] > lstUp[x + 1])
                        {
                            increase = "down";
                            intCount++;
                        }
                        else
                        {
                            if (intMax < intCount)
                            {
                                intMax = intCount;
                                index++;
                                lstUp.RemoveRange(0, index);
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (lstUp[x] < lstUp[x + 1])
                        {
                            increase = "up";
                            intCount++;
                        }
                        else
                        {
                            if (intMax < intCount)
                            {
                                intMax = intCount;
                                index++;
                                lstUp.RemoveRange(0, index);
                                break;
                            }
                        }
                    }
                }


            }


            while (lstDown.Count() > 0)
            {
                if ((intMax == lstUp.Count() - 1) || (intCount == lstUp.Count() - 1))
                    break;

                string increase = "down";
                int index = 0;
                for (int x = 0; x < lstDown.Count() - 1; x++)
                {

                    if (lstDown[x] == lstDown[x + 1])
                    {
                        index++;
                        lstDown.RemoveRange(x, index);
                        break;
                    }

                    if (increase == "down")
                    {
                        if (lstUp[x] < lstUp[x + 1])
                        {
                            increase = "up";
                            intCount++;
                        }
                        else
                        {
                            if (intMax < intCount)
                            {
                                intMax = intCount;
                                index++;
                                lstDown.RemoveRange(0, index);
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (lstDown[x] < lstDown[x + 1])
                        {
                            increase = "down";
                            intCount++;
                        }
                        else
                        {
                            if (intMax < intCount)
                            {
                                intMax = intCount;
                                index++;
                                lstDown.RemoveRange(0, index);
                                break;
                            }
                        }
                    }
                }
            }
            return intCount;
        }

        static int zigzag1(int[] a)
        {

            int intMax = 0;
            bool blUp = true;
            bool blDown = false;
            List<int> lstMod = new List<int>();
            lstMod = a.ToList();

            while (lstMod.Count() > 0)
            {
                int intCount = 0;
                for (int x = 0; x < lstMod.Count(); x++)
                {
                    if (blUp == true && blDown == false)
                    {
                        if (lstMod[x] > lstMod[x + 1])
                        {
                            intCount++;
                        }
                    }

                }
            }

            return intMax;
        }

        static int[] constructArray(int size)
        {
            List<int> lst = new List<int>();
            List<int> ret = new List<int>();
            var result = Enumerable.Range(1, size).ToList(); ;
            int sizes = size;
            int intCount = 0;

            //The idea here is to loop through all items on array, the for loop
            //here is just a way to loop everything but we will break it 
            //once we hit the target
            for (int x = 0; x < size; x++)
            {
                if (intCount < size)
                {
                    ret.Add(result[x]);
                    intCount++;
                }
                else
                {
                    break;
                }
                if (intCount < size)
                {
                    ret.Add(sizes--);
                    intCount++;
                }
                else
                {
                    break;
                }
            }
            return ret.ToArray();
        }

        static string[] newNumeralSystem(char number)
        {
            int x = (int)number - 65;
            List<int> lstGenerated = new List<int>();
            lstGenerated = Enumerable.Range(1, x).ToList();
            int intMax = x / 2;
            int intCount = 0;
            List<int[]> lst = new List<int[]>();

            lst.Add(new int[] { 0, x }); //Every combination has the start of this

            {
                for (int w = 1; w <= intMax; w++)
                {
                    for (int z = w; z <= x; z++)
                    {
                        if ((w + z) == x)
                        {
                            lst.Add(new int[] { w, z });
                            intCount++;
                            break;
                        }

                    }
                }

            }

            List<string> lstStringReturn = new List<string>();

            foreach (var item in lst)
            {
                lstStringReturn.Add((char)(item[0] + 65) + " + " + (char)(item[1] + 65));
            }

            return lstStringReturn.ToArray();

        }

        static int jumpingJimmy(int[] tower, int jumpHeight)
        {
            int intCounter = 0;
            bool blStop = false;
            tower.ToList().ForEach((c) =>
            {
                if ((c <= jumpHeight) && !blStop)
                    intCounter += c;
                else
                {
                    blStop = true;
                    return;
                }

            });
            return intCounter;
        }

        static int[] digitRootSort(int[] a)
        {
            //The technique here is put the list to a dictionary
            List<KeyValuePair<int, double>> lst = new List<KeyValuePair<int, double>>();
            List<double> temp = new List<double>();


            lst = a.ToDictionary(c => c, c => c.ToString().ToCharArray().Sum(w => char.GetNumericValue(w))).ToList<KeyValuePair<int, double>>();

            //Since we cannot change the position of the data on the keyvalue pair list, we need to pass this 
            //to a new variable
            var orderedList = lst.OrderBy(c => c.Value);

            //Group it, and the key is the group key, the value is the data under the group key
            var r = orderedList.GroupBy(w => w.Value)
                 .ToDictionary(zz => zz.Key, zz => zz.Select(s => s));
            //.Select(group => group.OrderBy(item => item.Key))
            //.SelectMany(zz => zz.Select(s => s.Key));
            //.ToList<int>(zz => zz.Select(a => a.Key), zz => zz.Select(s => s));

            //Then order the keyvalue pair list
            foreach (var item in r)
            {
                foreach (var i in item.Value.OrderBy(w => w.Key))
                {
                    temp.Add(i.Key);
                }
            }

            return temp.Select(w => (int)w).ToArray();
        }


        static bool evenDigitsOnly(int n)
        {
            //if (char.IsNumber(n[0]))
            //  return false;

            return n.ToString().ToCharArray().All(w => char.IsLetter(w) || char.IsNumber(w) || w == '_');
        }

        static string alphabeticShift(string inputString)
        {
            var ret = inputString.ToCharArray().Select(w => ((int)w + 1)).Select(z => (char)z)
                .Select(a =>
                {
                    if (a == '{')
                        a = 'a';
                    return a;
                });
            return string.Join("", ret);
        }

        static bool chessBoardCellColor(string cell1, string cell2)
        {
            //a b c d e f g h
            cell1 = cell1.ToLower();
            cell2 = cell2.ToLower();
            char[] chSetA = new char[] { 'a', 'c', 'e', 'g' };
            string blSetA = "";
            string blSetB = "";
            if (chSetA.Any(w => w == cell1[0]))
            {
                if (char.GetNumericValue(cell1[1]) % 2 == 1)
                {
                    blSetA = "dark";
                }
                else
                {
                    blSetA = "white";
                }
            }
            else
            {
                if (char.GetNumericValue(cell1[1]) % 2 == 1)
                {
                    blSetA = "white";
                }
                else
                {
                    blSetA = "dark";
                }
            }

            if (chSetA.Any(w => w == cell2[0]))
            {
                if (char.GetNumericValue(cell2[1]) % 2 == 1)
                {
                    blSetB = "dark";
                }
                else
                {
                    blSetB = "white";
                }
            }
            else
            {
                if (char.GetNumericValue(cell2[1]) % 2 == 1)
                {
                    blSetB = "white";
                }
                else
                {
                    blSetB = "dark";
                }
            }
            return blSetA == blSetB;
        }

        static int reverseInterference(string originalA, string originalB, string broadcastA, string broadcastB)
        {
            var oA = originalA.ToCharArray();
            var oB = originalB.ToCharArray();

            var bA = broadcastA.ToCharArray();
            var bB = broadcastB.ToCharArray();

            char[] tempCheck = new char[oA.Length];


            if (originalA == broadcastA && originalB == broadcastB)
                return 0;

            int intSwap = 0;
            int intCounter = 0;
            for (int x = 0; x < oA.Length; x++)
            {

                if ((oA[x] == bB[x] && oB[x] == bA[x]) && (oA[x] != oB[x]))
                {
                    tempCheck[x] = bA[x];
                    if (intCounter == 3)
                    {
                        intCounter = 0;
                    }

                    //if (intCounter > 0)
                    //{
                    //    if (((int)oA[x] - (int)oA[x - 1]) != 1)
                    //        intCounter = 0;
                    //}

                    if (intCounter <= 3)
                    {
                        intCounter++;
                        if (intCounter == 1)
                            intSwap++;
                    }

                }
                else
                {
                    tempCheck[x] = bB[x];
                    intCounter = 0;
                }
            }

            if ((string.Join("", tempCheck) != originalB) && intSwap > 0)
                return 0;
            return intSwap == 0 ? -1 : intSwap;
        }

        static int periodicSequence(int s0, int a, int b, int m)
        {
            List<int> lst = new List<int>();
            lst.AddRange(Enumerable.Repeat(-1, m));
            int intTemp = s0;
            for (int x = 0; x < 500; x++)
            {
                intTemp = (a * intTemp + b) % m;
                if (lst[intTemp] != -1)
                    return x - lst[intTemp];
                lst[intTemp] = x;
            }
            return 0;
        }

        static string encodingDecoding(string message)
        {
            List<string> lstDecoded = new List<string>();
            //Needs to decode - Convert the message from based hex to string
            if (char.IsNumber(message[0]))
            {
                for (int x = 0; x < message.Length; x += 2)
                {
                    var ret = ((char)message[x] + (char)message[x + 1]);
                }
            }
            //Needs to encode - Convert the message from string to hex
            else
            {

            }
            return string.Empty;
        }

        bool isConnectableListOfNum(string[] listOfNum)
        {
            return true;
        }



    }

    enum Gender
    {
        Male = 1,
        Female
    }

    enum phylum
    {

    }

    enum dietType
    {

    }

    public class Animal
    {
        public int ID;
        public string title;
        public enum phylum { };
        public enum dietType { };

        public phylum _phylum;
        public dietType _dietType;

        public Animal()
        {

        }

        public Animal(int id, string name, phylum phylum, dietType diet)
        {
            this.ID = ID;
            this.title = name;
            this._phylum = phylum;
            this._dietType = diet;
        }
    }

    public class Dog : Animal
    {
        public enum breed { };
        public int levelOfTraining;

        public void SayWoof()
        {
            Console.WriteLine("Woof");
        }
    }

    


}

