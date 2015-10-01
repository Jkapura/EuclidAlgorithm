using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GCDLogic
{
    public static class EuclidClass
    {
        public static int FindGCD(int first,int second)
        {
            while(second != 0)
            {
                int temp = first % second;
                first = second;
                second = temp;
            }
            return Math.Abs(first);
                
        }
        //NOD(A,B,C)=NOD((A,B),C)

        public static int FindGCD(int first, int second,int third)
        {
            
            return Math.Abs(FindGCD(FindGCD(first, second), third));
        }
        //NOD(A,B,C,D)= NOD( NOD( NOD(A,B), C ), D )

        public static int  FindGCD(params int[] args)
        {
            int tempGCD = FindGCD(args[0], args[1]);
            for(int i = 2 ; i < args.Length ; i++)
            {
                FindGCD(tempGCD, args[i]);
            }
            return Math.Abs(tempGCD);
        }
        // НОД(0, n) = n; НОД(m, 0) = m; НОД(m, m) = m;
        // НОД(1, n) = 1; НОД(m, 1) = 1;
        // Если m, n чётные, то НОД(m, n) = 2*НОД(m/2, n/2);
        // Если m чётное, n нечётное, то НОД(m, n) = НОД(m/2, n);
        // Если n чётное, m нечётное, то НОД(m, n) = НОД(m, n/2);
        //Если m, n нечётные и n > m, то НОД(m, n) = НОД((n-m)/2, m);
        //Если m, n нечётные и n<m, то НОД(m, n) = НОД((m-n)/2, n);

        public static int FindBinaryGCD(int first, int second)
        {
            first = Math.Abs(first);
            second = Math.Abs(second);
            if (first == 0 || second == 0)
                return first == 0 ? second : first;
            if (first == second)
                return first;
            if (first == 1 || second == 1)
                return 1;
            if ((first % 2 == 0) && (second % 2 == 0))
            { return 2 * FindBinaryGCD(first / 2, second / 2); }
            if ((first % 2 == 0) || (second % 2 == 0))
            { return (first % 2 == 0) ? FindBinaryGCD(first / 2, second) : FindBinaryGCD(first, second / 2); }
            //if(first>second)
            return (first > second) ? FindBinaryGCD((first - second) / 2, second) : FindBinaryGCD((second - first) / 2, first);
        }

        public static int FindBinaryGCD(int first,int second,int third)
        {
            return Math.Abs(FindBinaryGCD(FindBinaryGCD(first, second), third));
        }
        public static int FindBinaryGCD(params int[] args)
        {
            int tempGCD = FindBinaryGCD(args[0], args[1]);
            for(int i = 2; i < args.Length;i++ )
            {
                FindBinaryGCD(tempGCD, args[i]);
            }
            return Math.Abs(tempGCD);
        }
               
    
    }
}
