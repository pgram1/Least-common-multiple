using System;
using static System.Console;

class LCM {
  static void Main(String[] vars) {

    int[] numbas = Array.ConvertAll(vars, s =>int.Parse(s));

    int population = numbas.Length;
    if (population > 1) {

      int lcm = leastCommonMultiple(numbas, population);

      Write("------\nThe least common multiple is: " + lcm);

    } else {
      WriteLine("Not enough numbers\nUsage:\nlcm.exe [your numbers here]");
    }

  }

  static int leastCommonMultiple(int[] arr, int population) {
    for (int i = 1; i < population; i++)
    arr[i] = pairMultiple(arr[i - 1], arr[i]);
    return arr[population - 1];
  }

  static int pairMultiple(int x, int y) {
    int count = 1;
    while (count <= Int32.MaxValue) {
      if (count % x == 0 && count % y == 0) break;
      count++;
    }
    return count;
  }

}