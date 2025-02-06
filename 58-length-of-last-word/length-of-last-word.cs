public class Solution {
    public int LengthOfLastWord(string s) {
        string[] palabras = s.Trim().Split(' ');

        int longitudUltimaPalabra = palabras[^1].Length;

        return longitudUltimaPalabra;
    }
}