using System;

public class Constants {
    private static DateTime epocDate { get; } = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    public static double startEpocDate { get; } = DateTime.Now.ToUniversalTime().Subtract(epocDate).TotalMilliseconds;
    public static double getCurrentEpocDate() {
        return DateTime.Now.ToUniversalTime().Subtract(epocDate).TotalMilliseconds;
    }
}