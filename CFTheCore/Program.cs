using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Text.RegularExpressions;


namespace CFTheCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var proper = properOrImproper(new int[] { -3, 3 });
            var lucky = isLuckyNumber(47);
            var prime = primeFactors(100);
            var dec = decipher("code");

        }

        //Opposite
        static string decipher(string cipher)
        {
            var encode = Encoding.ASCII.GetBytes(cipher.ToCharArray());
            var result = cipher.ToCharArray().Select(c => Encoding.ASCII.GetBytes(c.ToString().ToCharArray()).Take(1).FirstOrDefault()).ToArray();
            string ret = "";
            foreach (var item in result)
            {
                ret += item;
            }
            return ret;
        }

        //Encode
        static string decipher1(string cipher)
        {
            string result = "";
            while (cipher.Length > 0)
            {
                string subs = cipher.Substring(0, 2);
                int intASCII = int.Parse(subs);
                if (intASCII >= 97)
                {
                    result += (char)n;
                    cipher = cipher.Substring(2);
                }
                else
                {
                    subs = cipher.Substring(0, 3);
                    intASCII = int.Parse(subs);
                    result += (char)intASCII;
                    cipher = cipher.Substring(3);
                }
            }
            return result;
        }

        /*
        static string decipher(string cipher)
        {
            var result = cipher.ToCharArray().Select(c => c).ToArray();
            string ret = "";
            foreach (var item in result)
            {
                ret += item;
            }
            return ret;
        }
        */
        int candles(int A, int B)
        {
            int burned = 0, left = 0;
            while (A > 0)
            {
                burned += A;
                left += A;
                A = left / B;
                left %= B;
            }
            return burned;
        }

        private static double computeDefiniteIntegral(int l, int r, int[] p)
        {
            double result = 0;
            int intExponent = l,
            rExponent = r;

            for (int x = 0; x < p.Count(); x++)
            {
                result += p[x] * (double)(rExponent - rExponent) / (x + 1);
                rExponent *= l;
                rExponent *= r;
            }

            return result;
        }

        static int dfsComponentSize(bool[][] matrix, int vertex)
        {
            int result = 0;
            for (int x = 0; x < matrix.Count(); x++)
            {
                if (matrix[x][vertex])
                    result++;
            }
            return result + 1;
        }

        bool shareAnApple(int a, int b)
        {
            if (--a == ++b)
                return true;
            return false;
        }

        int eulersTotientFunction(int n)
        {
            int divisor = 2;
            int result = n;

            while (divisor * divisor <= n)
            {
                if (n % divisor == 0)
                {
                    while (n % divisor == 0)
                    {
                        n /= divisor;
                    }
                    result -= result / divisor;
                }
                divisor++;
            }
            if (n > 1)
            {
                result -= result / n;
            }

            return result;
        }

        /*
           function areSimilarNumbers(a, b, divisor) {
          if (a % divisor === 0 && b % divisor === 0
              || a % divisor !== 0 && b % divisor !== 0) {
            return true;
          }
          return  false ;
        }
        */

        int[] eratosthenesSieve(int n)
        {
            IList<int> lst = new List<int>();
            for (int x = 2; x <= n; x++)
            {
                if (F(x))
                    lst.Add(x);
            }
            return lst.ToArray();
        }

        string mySubstringByLength(string inputString, int start, int length)
        {
            return inputString.Substring(start, length);
        }

        static bool evenDigitsOnly(int n)
        {
            return n.ToString().ToCharArray().All(c => c % 2 == 0);
        }

        static int[] primeFactors(int n)
        {
            List<int> lst = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0)
                {
                    lst.Add(i);
                    n /= i;
                    i = 1;
                }
            }
            return lst.ToArray();
        }

        static bool isLuckyNumber(int n)
        {
            //var res = n.ToString().ToCharArray().Select(c => c).Where(c => c != '4' && c != '7').Count();
            return n.ToString().ToCharArray().Select(c => c).Where(c => c != '4' && c != '7').Count() == 0;

        }

        int[] arrayPreviousLess(int[] items)
        {
            IList<int> result = new List<int>();
            for (int x = 0; x < items.Length; x++)
            {
                int intAdd = -1;
                for (int y = 0; y < x; y++)
                {
                    if (items[y] < items[x])
                    {
                        intAdd = items[y];
                    }
                }
                result.Add(intAdd);
            }

            return result.ToArray();
        }

        bool rightTriangle(int[] sides)
        {
            sides = sides.OrderBy(c => c).ToArray();
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);

        }

        int cyclicString(string s)
        {
            for (int i = 1; i <= s.Length; i++)
            {
                string strReturn = s.Substring(0, i);

                bool blIsCycle = true;
                for (int x = 0; x < s.Length; x++)
                {
                    if (s[x] != strReturn[x % strReturn.Length])
                    {
                        blIsCycle = false;
                        break;
                    }
                }
                if (blIsCycle)
                    return i;
            }
            return 0;
        }

        bool hangman(string word, string letters)
        {
            int r = 0, i = 0;
            string l = letters, b = word;
            for (; i < l.Length; i++)
            {
                if (b.Contains(l[i]))
                    b = b.Replace(l[i], ' ');
                else
                    r++;

                if (b.Trim() == "")
                    return true;
                if (r >= 6)
                    return false;
            }
            return false;
        }

        static string properOrImproper(int[] a)
        {
            var res = (double)a[0] / a[1];
            return Math.Abs((double)a[0] / a[1]) < 1 ? "Proper" : "Improper"; 
        }

        static int arrayMaximalDifference(int[] inputArray)
        {
            Array.Sort(inputArray);
            return inputArray[inputArray.Length - 1] - inputArray[0];

        }

        string[] sortByLength(string[] inputArray)
        {
            return inputArray.OrderByDescending(c => c).ToArray();
        }

        //solution: "function add($n, m) {\t  return n + $m;\t}"args: ["n", "m"]
        string programTranslation(string solution, string[] args)
        {
            string argumentVariants = String.Join("|", args);
            string pattern = argumentVariants;
            string sub = String.Join("", args); ;
            return Regex.Replace(solution, pattern, sub);
        }

        static int nextPrime(int n)
        {
            int intInput = n + 1;
            while (!F(intInput))
            {
                n++;
            }
            return intInput;
        }

        static int intFactorial(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return intFactorial(n - 1) + intFactorial(n - 2);
        }

        static int factorSum(int N)
        {

            var p = new List<int>();
            int o = 0;
            while (!F(o))
            {
                if (o == 0)
                    o = 0;
                else
                {
                    N = o;
                    p.Clear();
                }
                for (int i = 2; i <= N; i++)
                {
                    if (N % i == 0)
                    {
                        p.Add(i);
                        N /= i;
                        i = 1;
                    }
                }

                o = p.Sum(b => b);
                if (o == p.Aggregate((a, b) => a * b))
                    return o;

            }

            return o;
        }

        static bool F(int n)
        {
            if (n == 0) return false;
            return (Enumerable.Range(1, n).Count(x => n % x == 0) == 2);
        }

        static int exerciseElaboration(int p, int n)
        {
            var input = string.Join("", Enumerable.Repeat("0", n));
            var output = p.ToString() + input + p.ToString();
            return ((int)Math.Pow(int.Parse(output), 2)).ToString().ToCharArray().Select(c => c - 48).Sum();
        }

        static int maxDigit(int n)
        {
            return n.ToString().ToCharArray().Max(c => c - 48);
        }

        bool isTournament(int n, int[] f, int[] t)
        {
            return !f.Concat(t).Any() ? false : f.Concat(t).GroupBy(c=>c).All(c => c.Count() == n - 1);
        }

        /*
        bool isTournament(int n, int[] fromV, int[] toV)
        {
            if (fromV.Length == 0 && toV.Length == 0)
                return false;
            IList<int> lst = new List<int>();
            lst = lst.Concat(fromV.ToList()).ToList();
            lst = lst.Concat(toV.ToList()).ToList();

            var result = lst.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count()).All(c => c.Value == n - 1);
            return result;
        }
        */

        int arrayMode(int[] sequence)
        {
            return sequence.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count()).OrderByDescending(c => c.Value).Select(c => c.Key).Take(1).SingleOrDefault();
        }

        string swapCase(string text)
        {
            var res = text.ToString().ToCharArray();
            List<string> lst = new List<string>();
            for (int x = 0; x < res.Count(); x++)
            {
                if (char.IsUpper(res[x]))
                    lst.Add(res[x].ToString().ToLower());
                else
                    lst.Add(res[x].ToString().ToUpper());

            }
            return string.Join("", lst.ToArray());

        }

        static string cipher26(string message)
        {
            string result = string.Empty;
            int first = 0;
            int last = 0;
            for (int i = 0; i < message.Length; i++)
            {
                int t = message[i] - 97;
                first = t - last;
                if (first < 0)
                {
                    first = first + 26;
                }
                result += (char)(first + 97);
                last = t;
            }
            return result;
        }

        static int[] prefixSums(int[] a)
        {
            int[] result = new int[a.Length];
            for (var i = 0; i < a.Length; i++)
            {
                result[i] = 0;
                for (var j = 0; j < i + 1; j++)
                {
                    result[i] += a[j];
                }
            }
            return result;
        }

        static int sumOfTheAngles(int n)
        {
            return (n - 2) * 180;
        }

        static int lastDigit(int a, int b)
        {
            var x = Math.Pow(a, b);
            return (int)Char.GetNumericValue(x.ToString().ToCharArray()[x.ToString().ToCharArray().Count() - 1]);
        }

        bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            return (new int[] { friendsLeft, friendsRight }.Any(c => c == yourLeft)) && (new int[] { friendsLeft, friendsRight }.Any(c => c == yourRight));
        }

        static int arraySumAdjacentDifference(int[] inputArray)
        {
            int intSum = 0;
            for (int x = 1; x < inputArray.Length; x++)
            {
                intSum += Math.Abs(inputArray[x - 1] - inputArray[x]);
            }
            return intSum;
        }

        private static bool ortogonalLines(int[] line1, int[] line2)
        {

            if (line1[0] * line2[0] + line1[1] * line2[1] == 0)
            {
                return true;
            }
            return false;
        }

        static bool latinLettersSearchRegExp(string input)
        {
            return input.ToCharArray().Any(c => char.IsLetter(c));
        }

        /*
        bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)    
       
       => new int[] { friendsLeft, friendsRight }
       .Count(c => c == yourLeft || c == yourRight) == 2;
        */

        int[] arrayComplexElementsProduct(int[] real, int[] imag)
        {
            return null;
        }

        static int divideAsLongAsPossible(int n, int d)
        {
            while (n % d == 0)
            {
                n /= d;
            }
            return n;
        }

        int numberOfOperations(int a, int b)
        {
            int intCounter = 0;
            while (a % b == 0 || b % a == 0)
            {
                if (a % b == 0)
                    a /= b;
                else
                    b /= a;
                intCounter++;
            }
            return intCounter;
        }

        static int parabole(int a, int b, int c, int x)
        {
            return (a * b * b) + b * x + c;
        }

        static int fncBinomial(int n, int k)
        {
            if (k == n)
                return (int)Math.Pow(n, -1);
            if (k == 0)
                return 0;

            return fncBinomial(n - 1, k - 1) + (fncBinomial(n, k - 1));
        }

        static int differentSquares(int[][] matrix)
        {
            return matrix.SelectMany(c => c).Count() / 2;
        }

        static int piecesOfDistinctLengths(int strawLength)
        {
            int n = 0, s = 0;
            while (s <= strawLength)
            {
                s += n;
                n++;
            }
            return (n - 2);
        }

        char lastDigitRegExp(string inputString)
        {
            return inputString.ToCharArray().Select((a, b) => new { Value = a, Index = b }).Where(c => char.IsNumber(c.Value)).OrderByDescending(c => c.Index).Select(c => c.Value).Take(1).SingleOrDefault();
        }

        int matrixTrace(int[][] matrix)
        {
            int intResult = 0;
            for (int x = 0; x < matrix.Length; x++)
            {
                intResult += matrix[x][x];
            }
            return intResult;
        }

        string[] splitAddress(string address)
        {
            string[] str = new string[] { "://", ".com", "/" };
            return address.Split(str, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        static bool regularBracketSequence2(string sequence)
        {
            var b = sequence.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());
            if (sequence.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count()).All(c => c.Value % 2 == 0))
                return true;
            if (sequence.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count()).Count(c => c.Value % 2 == 1) == 2)
                return true;
            return false;
        }

        bool regularBracketSequence1(string sequence)
        {
            if (sequence.ToCharArray()[0] != '(')
                return false;
            if (sequence.ToCharArray()[sequence.ToCharArray().Count() - 1] != ')')
                return false;
            var b = sequence.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());
            if (sequence.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count()).All(c => c.Value % 2 == 0))
                return true;
            if (sequence.ToCharArray().GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count()).Count(c => c.Value % 2 == 1) == 2)
                return true;

            return false;

        }

        static int digitDegree(int n)
        {
            var res = n.ToString().ToCharArray();
            if (res.Count() == 1)
                return 0;
            int intCounter = 0;
            while (res.Count() > 1)
            {
                res = res.Sum(c => c - 48).ToString().ToCharArray();
                intCounter++;
            }
            string str = string.Join("", res);
            return intCounter;
        }

        int maxSubmatrixSum(int[][] matrix, int n, int m)
        {

            var intResult = 0;
            for (var i = 0; i + n <= matrix.Length; i++)
            {
                for (var j = 0; j + m <= matrix[0].Length; j++)
                {
                    var sum = 0;
                    for (var x = 0; x < n; x++)
                    {
                        for (var y = 0; y < m; y++)
                        {
                            sum += matrix[i + x][j + y];
                        }
                    }
                    if (i == 0 && j == 0 || sum > intResult)
                    {
                        intResult = sum;
                    }
                }
            }
            return intResult;

        }

        bool pointInLine(int[] point, int[] line)
        {
            return line[0] * point[0] + line[1] * point[1] + line[2] == 0;
        }

        static int evenNumbersBeforeFixed(int[] sequence, int fixedElement)
        {
            if ((sequence.Select((a, b) => new { Value = a, Index = b }).Where(c => c.Value == fixedElement).Select(c => c.Index).Take(1).SingleOrDefault() + 1) / 2 == 0)
                return -1;
            return (sequence.Select((a, b) => new { Value = a, Index = b }).Where(c => c.Value == fixedElement).Select(c => c.Index).Take(1).SingleOrDefault() + 1) / 2;
        }

        int[] threeAndFour(int n)
        {
            //int x = 1;
            List<int> lstResult = new List<int>();
            for (int x = 0; x <= n; n /= x += 12)
            {
                if (x % 12 == 0)
                    lstResult.Add(x);

            }
            return lstResult.ToArray();
        }

        private static int equationSolutions(int L, int R)
        {
            int result = 0;
            for (int i = L; i <= R; i++)
                for (int j = L; j <= R; j++)
                    if (i * i * i == j * j)
                        result++;
            return result;
        }

        bool arithmeticExpression(int a, int b, int c)
        {
            //Expression e = new Expression("(4+8)*2");
            return true;
        }

        bool arePrizesOK(int first, int second, int third)
        {
            return first > second && second >= third;
        }

        //int boxPiles(int[] a) => a.Max(n => (n++ + a.Count(x => x < n)) / n);

        static int oddNumbersBeforeZero(int[] sequence)
        {
            int result = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == 0)
                    return result;
                if (sequence[i] % 2 != 0)
                    result++;
            }
            return result;
        }

        static int boxPiles(int[] a)
        {

            //a = a.OrderBy(c => c).ToArray();

            //int[] x = new int[a.Length];
            //int usedNum = 0;
            //int answer = 0;
            //while (usedNum < x.Length)
            //{
            //    int toBeUp = 0;
            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        if (a[i] >= toBeUp && !x[i])
            //        {
            //            toBeUp++;
            //            x[i] = true;
            //            usedNum++;
            //        }
            //    }
            //    answer++;
            //}

            return 0;
            //return answer;
        }

        int kthDigit(int n, int k)
        {
            int x = 0, y = n;
            while (y != 0)
            {
                x++;
                y /= 10;
            }

            int z = x - k + 1;

            while (n != 0)
            {
                if (--z == 0)
                {
                    return n % 10;
                }
                n /= 10;
            }

            return -1;
        }

        string measureHuevos(float g, object a)
        {
            //int c = 0;
            a = a == "hd" ? 6 : a == "d" ? 12 : a == "bd" ? 13 : 144;

            g = g / (float)a;

            return g >= 70.9 ? "j" : g >= 63.8 ? "xl" : g >= 56.7 ? "l" : g >= 49.6 ? "m" : g >= 42.5 ? "s" : g >= 35.4 ? "p" : "nope";
        }

        static string measureHuevos1(int g, string ct)
        {
            //if (g == 0)
            //          return "nope";
            int c = 0;
            switch (ct)
            {
                case "hd":
                    c = 6;
                    break;
                case "d":
                    c = 12;
                    break;
                case "bd":
                    c = 13;
                    break;
                case "g":
                    c = 144;
                    break;

                default:
                    break;
            }
            double result = (Convert.ToDouble(g) / Convert.ToDouble(c));
            if (result <= 34)
                return "nope";
            if (result >= 35.4 && result < 42.5)
                return "p";
            if (result >= 42.5 && result < 49.6)
                return "s";
            if (result >= 49.6 && result < 56.7)
                return "m";
            if (result >= 56.7 && result < 63.8)
                return "l";
            if (result >= 63.8 && result < 70.9)
                return "xl";
            if (result >= 70.9)
                return "j";
            return "";
        }

        static int a = 1;

        static int functionModulus(int n)
        {
            for (; n % ++a > 0; ) ;
            return 0;
        }

        bool increaseNumberRoundness(int n)
        {
            bool blIsActive = false;
            while (n > 0)
            {
                if (n % 10 == 0 && blIsActive)
                {
                    return true;
                }
                if (n % 10 != 0)
                {
                    blIsActive = true;
                }
                n /= 10;
            }

            return false;
        }

        static int equalPairOfBits(int n, int m)
        {
            var num1 = Convert.ToString(n, 2).ToCharArray();
            var num2 = Convert.ToString(m, 2).ToCharArray();
            int index = num1.Where(c => num2.Contains(c)).Select(c => c).Take(1).SingleOrDefault();
            return index;
        }

        static int maxMultiple(int divisor, int bound)
        {
            if (bound % divisor == 0)
                return bound;
            int x = bound;
            for (; --x % divisor > 0; ) ;
            return x;
        }

        int fibonacciNumber(int n)
        {
            double sqrt5 = Math.Sqrt(5);
            double p1 = (1 + sqrt5) / 2;
            double p2 = -1 * (p1 - 1);


            double n1 = Math.Pow(p1, n + 1);
            double n2 = Math.Pow(p2, n + 1);
            return (int)((n1 - n2) / sqrt5);
        }

        static int dinerTables(long n)
        {
            int x = 1;
            for (; x <= n; n /= x++) ;
            return x;
        }

        static int champernowneDigit(int n)
        {


            var result = Enumerable.Range(1, 200).ToArray();
            var join = string.Join("", result).ToCharArray().Select((a, b) => new { Value = a, Index = b }).Where(c => c.Index == n).Select(c => c.Value).Take(1).SingleOrDefault();

            //.Select((a, b) => new { Value = a, Index = b }).Where(c => c.Index == n).Select(c => c.Value).Take(1).SingleOrDefault();
            //var 
            return 1;
            //SelectMany((a, b) => new { Value = a, Index = b }).Where(c => c.Index == n).Select(c => c.Value).Take(1).SingleOrDefault();
        }

        int digitSum(int n)
        {
            //return 1;
            return n.ToString().ToCharArray().Select(c => c - 48).Sum();
        }

        int arrayPacking(int[] a)
        {
            if (1 <= a.Length && a.Length <= 4)
            {
                int result = 0;
                for (int index = 0; index < a.Length; index++)
                {
                    if (a[index] < 256 && a[index] > 0)
                    {
                        result += a[index] << 8 * index;
                    }
                }
                return result;
            }
            return 0;
        }
    }
}

/*
            int result = equalPairOfBits(2, 3);
            //int result = evenNumbersBeforeFixed(new int[] { 1, 4, 2, 6, 3, 1 }, 6);
            //int x = digitDegree(99);
            //bool bl = regularBracketSequence2("[()()]");
            //int r = fncBinomial(10, 3);
            //int piece = piecesOfDistinctLengths(13);
            //int para = parabole(1, 2, 3, -1);
            //int divide = divideAsLongAsPossible(36, 3);
            //int last = lastDigit(999999, 1000000);
            int result = arraySumAdjacentDifference(new int[] { 4, 7, 1, 2 });
            int[] res = prefixSums(new int[] { 1, 2, 3 });

            var a = new string[] { };
            string[] b = null;
            var c = new string[] { "hello" };

            var aa = a.Any();
            var bb = (b != null) && b.Any();
            var cc = c.Any();

            var aaa = a.IsNullOrEmpty();
            var bbb = a.IsNullOrEmpty();
            var ccc = c.IsNullOrEmpty();
            int res1 = exerciseElaboration(5, 1);
            int intNextPrime = nextPrime(8);

 */
