// Logger.java
public class Logger {

    // Step 1: Private static variable to hold the single instance
    private static Logger instance;

    // Step 2: Private constructor to prevent instantiation
    private Logger(String LoggerName) {
        System.out.println("Logger[" +LoggerName+ "] is Initialized");
    }

    // Step 3: Public static method to provide access to the instance
    public static Logger getInstance(String LoggerName) {
        if (instance == null) {
            instance = new Logger(LoggerName);  // create instance if not created yet
        }
        else{
            System.out.println("Logger already Initialized");
        }
        return instance;
    }

    // Optional: Sample logging method
    public void log(String message) {
        System.out.println("Log: " + message);
    }

}
