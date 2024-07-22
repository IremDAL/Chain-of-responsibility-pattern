using System.Collections.Generic;

public interface ILogService
{
    void Log(string message);
    List<string> GetLogs();
}
