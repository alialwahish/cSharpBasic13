using System;
using System.Collections.Generic;
namespace basic13
{
    class Program
    {


        public static void printNum1_255(){
            for(int i=0;i<=255;i++){
                Console.WriteLine(i);
            }
        }

        public static void printOddNum1_255(){
            for(int i=0;i<=255;i++){
                if(!(i%2==0)){

                Console.WriteLine(i);
                }
            }
        }


        public static void printSumNum1_255(){
            int sum=0;
            for(int i=0;i<=255;i++){        
                sum+=i;
                Console.WriteLine(i+" sum "+sum);
                
            }
        }

        public static void itrThruArr(Array arr){
            foreach(var itm in arr){
                Console.WriteLine(itm);
            }
        }

        public static int findMax(int[] arr){
            int max =arr[0];
            for (int i=0;i<=arr.Length;i++){
                if (arr[i]>max){
                    max=arr[i];
                }
            }
            return max;
        }

        public static int arrAvg(int[] arr){
            int sum=0;
            for(int i=0 ;i<arr.Length;i++){
                sum+=arr[i];
            }
            return sum/arr.Length;
        }

            public static Array oddArr(int[] arr){
            List<int> oddList = new List<int>();
                        
            for(int i=0 ;i<arr.Length;i++){
                if(!(arr[i]%2==0)){
                    oddList.Add(arr[i]);
                }
            }
            int[] oddArr=new int[oddList.Count];
            for(int i =0;i<oddList.Count;i++){
                oddArr[i]=oddList[i];
            }
            return oddArr;
        }


        public static Array squareArr(int[] arr){
            for(int i=0;i<arr.Length;i++){
                arr[i]=arr[i]*arr[i];
            }
            return arr;
        }
    
        
        public static Array remNeg(int[] arr){
            for(int i=0;i<arr.Length;i++){
                if(arr[i]<0){
                    arr[i]=0;
                }
            }
            return arr;
        }

         public static void minMaxAvg(int[] arr){
            int avg,min,max=arr[0];
            min=max;
            avg=0;
            
            for(int i=0;i<arr.Length;i++){
                if(arr[i]<min){
                    min=arr[i];
                }
                else if(arr[i]>max){
                    max=arr[i];
                }
                avg+=arr[i];
                
            }
            Console.WriteLine("Min: "+min+" Max: "+max+" Avg;"+avg/arr.Length);
            
            
        }

        public static void shiftArr(int[] arr){
            for(int i=0;i<arr.Length;i++){
                arr[i]=arr[i+1];
            }
            arr[arr.Length-1]=0;
        }

        public static  Array numToString(int[] arr){
            object[] strArr=new object[arr.Length];
            for(int i=0;i<arr.Length;i++){
               if(arr[i]<0){
                   strArr[i]="Dojo";
               }
               else{
                   strArr[i]=arr[i];

               }
            }
            return strArr;

        }






        static void Main(string[] args)
        {
            int[] arr={-1,-2,5};
            object newArr=new object[arr.Length];
            newArr=numToString(arr);
            
            

        }
    }
}
