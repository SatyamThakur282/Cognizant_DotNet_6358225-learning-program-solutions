
//  Step 2: Creating a method futureValue to calculate future value using recursive appraoch with past values.

package Finanacial_Forecasting;

public class Futurevalue {
    
    public static double futureValue(double presentValue, double growthRate, int years) {
        if (years == 0) {
            return presentValue;
        }
        return futureValue(presentValue, growthRate, years - 1) * (1 + growthRate);
    }

    public static void main(String[] args) {
        double presentValue = 10000.0;
        double growthRate = 0.05; // 5% annual growth
        int years = 5;

        double result = futureValue(presentValue, growthRate, years);
        System.out.printf("Future value after "+ years + " years: %.2f Rupees" ,result);
    }

}
