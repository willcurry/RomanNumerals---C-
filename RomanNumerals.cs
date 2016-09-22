public class RomanNumerals {
    public string convertToNumeral(int number) {
        string[] symbols = {"M", "CM","D","CD","C","XC","L","XL", "X", "IX", "V", "IV", "I"};
        int[] numbers = {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        string numeral = "";
        for (int i=0; i < numbers.Length; i++) {
            while (number >= numbers[i]) {
                numeral += symbols[i];
                number -= numbers[i];
            }
        }
        return numeral;
    }
}