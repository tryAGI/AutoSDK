//HintName: G.Models.SessionsListStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SessionsListStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionsListStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionsListStatus value)
        {
            return value switch
            {
                SessionsListStatus.Completed => "COMPLETED",
                SessionsListStatus.Error => "ERROR",
                SessionsListStatus.Running => "RUNNING",
                SessionsListStatus.TimedOut => "TIMED_OUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionsListStatus? ToEnum(string value)
        {
            return value switch
            {
                "COMPLETED" => SessionsListStatus.Completed,
                "ERROR" => SessionsListStatus.Error,
                "RUNNING" => SessionsListStatus.Running,
                "TIMED_OUT" => SessionsListStatus.TimedOut,
                _ => null,
            };
        }
    }
}