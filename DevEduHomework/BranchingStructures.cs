namespace DevEduHomework
{
    public static class BranchingStructures
    {
        public static int ComparisonAndArithmeticOperations(int first_number, int second_number)
        {
            int result = 0;
            if (first_number > second_number)
            {
                result = first_number + second_number;
            }
            if (first_number == second_number)
            {
                result = first_number * second_number;
            }
            if (first_number < second_number)
            {
                result = first_number - second_number;
            }
            return result;
        }
        public static string DefinitionOfAQuarter(int x, int y)
        {
            string result = "";
            if (x > 0 && y > 0)
            {
                result = "1 cetvert";
            }
            if (x > 0 && y < 0)
            {
                result = "4 cetvert";
            }
            if (x < 0 && y > 0)
            {
                result = "2 cetvert";
            }
            if (x < 0 && y < 0)
            {
                result = "3 cetvert";
            }
            return result;
        }
        public static string DefinitionOfAQuarter(int first_number, int second_number, int third_number)
        {
            string result = "";
            if (first_number > second_number && first_number > third_number)
            {
                if (second_number > third_number)
                    result = "B<C<A";
                else
                    result = "C<B<A";
            }
            if (second_number > first_number && second_number > third_number)
            {
                if (first_number > third_number)
                    result = "C<A<B";
                else
                    result = "A<C<B";
            }
            if (third_number > first_number && third_number > second_number)
            {
                if (first_number > second_number)
                    result = "B<A<C";
                else
                    result = "A<B<C";
            }
            return result;
        }
        public static string SolvingTheEquationThroughTheDiscriminant(int first_number, int second_number, int third_number)
        {
            double discriminant = second_number * second_number - (4 * first_number * third_number);
            string result = "";
            if (discriminant > 0)
            {
                double x1 = (double)(-second_number + Math.Sqrt(discriminant)) / (2 * first_number);
                double x2 = (double)(-second_number - Math.Sqrt(discriminant)) / (2 * first_number);
                result = ($"x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x1 = (double)(-second_number) / (2 * first_number);
                result = ($"x1 = {x1}");
            }
            else
            {
                result = "No roots!";
            }
            return result;
        }
        public static string WriteNumbers(int number)
        {
            int desyatki, ostatok;
            desyatki = number / 10;
            ostatok = number % 10;
            string result = "";
            string result_desyatki = "";
            string result_ostatok = "";
            if (number < 20)
            {
                switch (number)
                {
                    case 10:
                        result = ("desat");
                        break;
                    case 11:
                        result = ("odinadcat");
                        break;
                    case 12:
                        result = ("dvenadcat");
                        break;
                    case 13:
                        result = ("trinadcat");
                        break;
                    case 14:
                        result = ("cetirnadcat");
                        break;
                    case 15:
                        result = ("pyatnadcat");
                        break;
                    case 16:
                        result = ("westnadcat");
                        break;
                    case 17:
                        result = ("semnadcat");
                        break;
                    case 18:
                        result = ("vosemnadcat");
                        break;
                    case 19:
                        result = ("devyatnadcat");
                        break;
                }
                return result;
            }
            else
            {
                switch (desyatki)
                {
                    case 2:
                        result_desyatki = ("dvadcat ");
                        break;
                    case 3:
                        result_desyatki = ("tridcat ");
                        break;
                    case 4:
                        result_desyatki = ("sorok ");
                        break;
                    case 5:
                        result_desyatki = ("pyatdesat ");
                        break;
                    case 6:
                        result_desyatki = ("westisat ");
                        break;
                    case 7:
                        result_desyatki = ("semdisat ");
                        break;
                    case 8:
                        result_desyatki = ("vosemdesat ");
                        break;
                    case 9:
                        result_desyatki = ("devenosto ");
                        break;
                }
                switch (ostatok)
                {
                    case 1:
                        result_ostatok = ("odin");
                        break;
                    case 2:
                        result_ostatok = ("dva");
                        break;
                    case 3:
                        result_ostatok = ("tri");
                        break;
                    case 4:
                        result_ostatok = ("cetiri");
                        break;
                    case 5:
                        result_ostatok = ("pyat");
                        break;
                    case 6:
                        result_ostatok = ("west");
                        break;
                    case 7:
                        result_ostatok = ("sem");
                        break;
                    case 8:
                        result_ostatok = ("vosem");
                        break;
                    case 9:
                        result_ostatok = ("devyat");
                        break;
                }
                return result_desyatki + result_ostatok;
            }
        }
    }
}
