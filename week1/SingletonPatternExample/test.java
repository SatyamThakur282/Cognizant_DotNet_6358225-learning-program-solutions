public class test {
    
    public static void main(String[] args) {
        // Logger Satyam = Logger.getInstance("Satyam");
        // Logger cognizant = Logger.getInstance("Cognizant");
        // SingletonTest.java

        // Step 1: Get the logger instance
        Logger logger1 = Logger.getInstance("logger1");
        logger1.log("This is the first message.");

        // Step 2: Get the logger instance again
        Logger logger2 = Logger.getInstance("logger2");
        logger2.log("This is the second message.");

        // Step 3: Compare both references
        if (logger1 == logger2) {
            System.out.println("Both logger1 and logger2 point to the same instance.");
        } else {
            System.out.println("Different instances exist (NOT singleton).");
        }

    }





}
