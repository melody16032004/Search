using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public class MySort
    {
        private int[] a;
        private Random rand = new Random();

        public MySort()
        {
            a = new int[rand.Next(3, 9)];
            for (int i = 0; i < a.Length; i++)
            {
                this.a[i] = rand.Next(0, 10);
            }
        }
        public MySort(int k)
        {
            this.a = new int[k];
            for (int i = 0; i < k; i++)
            {
                this.a[i] = rand.Next(0, 10);
            }
        }
        public MySort(int[] a)
        {
            this.a = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                this.a[i] = a[i];
            }
        }

        public void Output()
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        public int LinearSearch(int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }
        public int BinarySearch(int x)
        {

            int l = 0;
            int r = a.Length - 1;
            int m = (l + r) / 2;

            while (l < r)
            {
                if (this.a[m] == x)
                {
                    return m;
                }
                if (x < this.a[m])
                {
                    r = m - 1;
                }
                else if (x > this.a[m])
                {
                    l = m + 1;
                }
                m = (l + r) / 2;
            }
            return -1;
        }

        public void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
        public void InterchangeSort()
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (this.a[i] > this.a[j])
                    {
                        Swap(ref this.a[i], ref this.a[j]);
                    }
                }
            }
        }
        public void BubbleSort()
        {
            bool isSTOP = false;
            for (int i = 0; i < a.Length - 2; i++)
            {
                for (int j = a.Length - 2; j >= i; j--)
                {
                    if (a[j] > a[j + 1])
                    {
                        Swap(ref this.a[j], ref this.a[j + 1]);

                        isSTOP = false;
                    }
                    else
                        isSTOP = true;
                }
                if (isSTOP == true)
                {
                    break;
                }
            }
        }
        public void HeapSort()
        {
            int n = a.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(a, n, i);

            for (int i = n - 1; i >= 0; i--)
            {
                Swap(ref this.a[0], ref this.a[i]);
                Heapify(a, i, 0);
            }
        }
        private void Heapify(int[] a, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && a[left] > a[largest])
                largest = left;

            if (right < n && a[right] > a[largest])
                largest = right;

            if (largest != i)
            {
                Swap(ref this.a[i], ref this.a[largest]);
                Heapify(a, n, largest);
            }
        }
        public void SelectionSort()
        {
            for (int i = 0; i <= a.Length - 2; i++)
            {
                int posMin = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[posMin] > a[j])
                    {
                        posMin = j;
                    }
                }
                Swap(ref a[i], ref a[posMin]);
            }
        }
        public void QuickSort(int[] a, int l, int r)
        {
            if (l < r)
            {
                int pivotIndex = Partition(a, l, r);
                if (pivotIndex > 1)
                {
                    QuickSort(a, l, pivotIndex - 1);
                }
                if (pivotIndex + 1 < r)
                {
                    QuickSort(a, pivotIndex + 1, r);
                }
            }
        }
        public int Partition(int[] a, int l, int r)
        {
            int pivot = a[(l + r) / 2];
            while (true)
            {
                while (a[l] < pivot)
                {
                    l++;
                }
                while (a[r] > pivot)
                {
                    r--;
                }
                if (l < r)
                {
                    //if (a[l] == a[r]) return pivot;

                    Swap(ref a[l], ref a[r]);
                }
                else
                {
                    return pivot;
                }
                Output();
            }
        }
        public void InsertionSort()
        {
            int pos;
            for (int i = 1; i < a.Length; i++)
            {
                int x = a[i];
                pos = i - 1;
                while (pos >= 0 && x < a[pos])
                {
                    a[pos + 1] = a[pos];
                    pos--;
                }
                a[pos + 1] = x;
            }
        }

        private int Check_Length(string num1, string num2)
        {
            int length1 = num1.Length;
            int length2 = num2.Length;
            int length = 0;
            if (length1 < length2)
            {
                length = length2;
                return length;
            }
            else if (length1 > length2)
            {
                length = length1;
                return length;
            }
            return length1;
        }

        ///Add long number
        public string Add(string num1, string num2)
        {
            int length = Check_Length(num1, num2);
            int[] array_num1 = new int[length];
            int length_array_num1 = array_num1.Length;
            int[] array_num2 = new int[length];
            int length_array_num2 = array_num2.Length;

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                length_array_num1--;
                array_num1[length_array_num1] = int.Parse(num1[i].ToString());
            }
            for (int i = num2.Length - 1; i >= 0; i--)
            {
                length_array_num2--;
                array_num2[length_array_num2] = int.Parse(num2[i].ToString());
            }

            int[] sum = new int[length];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = array_num1[i] + array_num2[i];
            }
            for (int i = sum.Length - 1; i > 0; i--)
            {
                if (sum[i] >= 10)
                {
                    sum[i] = sum[i] % 10;
                    sum[i - 1] += 1;
                }
            }

            string sum_int = "";
            for (int i = 0; i < sum.Length; i++)
            {
                sum_int += sum[i].ToString();
            }

            return sum_int;
        }
    }
}
