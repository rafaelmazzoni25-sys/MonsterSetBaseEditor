using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace MonasterSetBase
{
  internal static class EditorLogger
  {
    private static readonly object SyncRoot = new object();
    private static readonly string LogDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
    private static readonly string LogFilePath = Path.Combine(LogDirectory, "MonsterSetBaseEditor.log");

    public static void LogInfo(string message) => WriteEntry("INFO", message, (Exception) null);

    public static void LogWarning(string message) => WriteEntry("WARN", message, (Exception) null);

    public static void LogError(string message, Exception exception)
    {
      WriteEntry("ERROR", message, exception);
    }

    private static void WriteEntry(string level, string message, Exception exception)
    {
      try
      {
        lock (SyncRoot)
        {
          if (!Directory.Exists(LogDirectory))
            Directory.CreateDirectory(LogDirectory);
          using (StreamWriter streamWriter = new StreamWriter(LogFilePath, true, Encoding.UTF8))
          {
            string str = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", (IFormatProvider) CultureInfo.InvariantCulture);
            streamWriter.WriteLine(str + " [" + level + "] " + message);
            if (exception != null)
              streamWriter.WriteLine(exception.ToString());
          }
        }
      }
      catch
      {
      }
    }
  }
}
