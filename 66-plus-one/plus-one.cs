public class Solution {
    public int[] PlusOne(int[] digits) {
        // Empezamos desde el último dígito
        for (int i = digits.Length - 1; i >= 0; i--) {
            if (digits[i] < 9) {
                digits[i]++;  // Si el dígito no es 9, simplemente sumamos 1 y terminamos
                return digits;
            }
            digits[i] = 0;  // Si el dígito es 9, lo cambiamos a 0 y seguimos
        }

        // Si llegamos aquí, significa que todos los dígitos eran 9
        int[] result = new int[digits.Length + 1];
        result[0] = 1;  // La primera posición será 1 (por el "plus one")
        return result;
    }
}