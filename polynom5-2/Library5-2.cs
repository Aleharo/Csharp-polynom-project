using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library5_2
{
    public class Polynomial
    {
        private int[] polynomConstants;

        public Polynomial(int[] inputPolynomialConstantsInDescendingtOrder)
        {
            this.polynomConstants = (int[])inputPolynomialConstantsInDescendingtOrder.Clone();
        }

        public int DegreeOfPolynomial
        // Returns the highest degree of polynomial
        {
            get
            {
                for (int i=polynomConstants.Length-1; i>=0; i--)
                {
                    if (polynomConstants[i] != 0)
                        return i;
                }
                return 0;
            }
        }

        public static Polynomial operator +(Polynomial a, Polynomial b)
        // Adding polynomials 
        {
            int length = Math.Max(a.DegreeOfPolynomial + 1, b.DegreeOfPolynomial + 1);
            int[] result = new int[length];


            for (int i = 0; i < length; i++)
            {
                result[i] = a[i] + b[i];
            }

            Polynomial constance = new Polynomial(result);
            return constance;
        }
        public static Polynomial operator -(Polynomial a, Polynomial b)
        // Subtracting polynomials
        {
            int length = Math.Max(a.DegreeOfPolynomial + 1, b.DegreeOfPolynomial + 1);
            int[] result = new int[length];


            for (int i = 0; i < length; i++)
            {
                result[i] = a[i] - b[i];
            }

            Polynomial constance = new Polynomial(result);
            return constance;
        }

        public static Polynomial operator *(Polynomial a, Polynomial b)
        // Polynomial Multiplication 
        {

            int length = (a.DegreeOfPolynomial + b.DegreeOfPolynomial + 1);
            int[] result = new int[length];


            for (int i = 0; i <= a.DegreeOfPolynomial; i++)
            {
                for (int j = 0; j <= b.DegreeOfPolynomial; j++)
                    result[i + j] += a[i] * b[j];
            }

            Polynomial constance = new Polynomial(result);
            return constance;
        }

        public int this[int index]
        {
            // Sets or gets the polynomial constant
            get
            {
                if ((index < 0) | index > DegreeOfPolynomial)
                    return 0;
                return polynomConstants[index];
            }

            set
            {
                if (index < 0)
                    index = 0;
                else if (index > DegreeOfPolynomial)
                {
                    // Creates new array if index > max power of x in polynomial
                    int[] newArray = new int[index + 1];
                    Array.Copy(polynomConstants, newArray, polynomConstants.Length);
                    polynomConstants = newArray;
                }

                polynomConstants[index] = value;
            }
        }

        public string Print()
        {
            // Returns polynomial in 'ax^2 + bx + c' format
            string result = "";


            for (int i = polynomConstants.Length - 1; i >= 0; i--)
            {
                if (polynomConstants[i] > 0)
                {
                    if (result != "")
                        result += "+ ";
                }
                else if (polynomConstants[i] == 0)
                    continue;

                if (i == 0)
                    result += (string)(polynomConstants[i] + "");
                else if (i == 1)
                    result += (string)(polynomConstants[i] + "x ");
                else
                    result += (string)(polynomConstants[i] + "x^" + i + " ");
            }

            return result;
        }
    }
}
