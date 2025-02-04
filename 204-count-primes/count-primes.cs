public class Solution {
    public int CountPrimes(int n) {
        if (n <= 2) return 0; 
        
        bool[] esPrimo = new bool[n];
        Array.Fill(esPrimo, true); // Inicializamos todos los números como primos
        esPrimo[0] = esPrimo[1] = false; // 0 y 1 no son primos
        
        for (int i = 2; i * i < n; i++) {
            if (esPrimo[i]) {
                for (int j = i * i; j < n; j += i) { 
                    esPrimo[j] = false; // Marcamos los múltiplos de i como no primos
                }
            }
        }
        
        int counter = 0;
        for (int i = 2; i < n; i++) {
            if (esPrimo[i]) counter++;
        }

        return counter;
    }
}
