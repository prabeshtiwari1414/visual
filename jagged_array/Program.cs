using System;
  
class JagAr {
      
    public static void Main()
    {
          
        string[][] jagged_arr = new string[8][];
  
        jagged_arr[0] = new string[] {"Hello!"};
        jagged_arr[1] = new string[] {"My"," Name"," Is"," Prabesh"," Tiwari"," .","."};
        jagged_arr[2] = new string[] {"Address"};
        jagged_arr[3] = new string[] {"Suka"," Gandaki"," 1"," Serabesi","."};
        jagged_arr[4] = new string[] {"School"};
        jagged_arr[5] = new string[] {"Shree"," Brahma"," Rupa", " Secondary", " School"};
        jagged_arr[6] = new string[] {".........","...........","............."};
        jagged_arr[7] = new string[] {".........","...........","............."};

  
        for (int n = 0; n < jagged_arr.Length; n++) {
  
      
  
            for (int k = 0; k < jagged_arr[n].Length; k++) {
  
                // Print the elements in the row
                Console.Write(jagged_arr[n][k]);
            }
            Console.WriteLine();
        }
    }
}