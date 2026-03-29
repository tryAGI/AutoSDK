//HintName: G.Models.EventsListResponseResultStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the event.
    /// </summary>
    public enum EventsListResponseResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Running,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventsListResponseResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventsListResponseResultStatus value)
        {
            return value switch
            {
                EventsListResponseResultStatus.Failed => "FAILED",
                EventsListResponseResultStatus.Pending => "PENDING",
                EventsListResponseResultStatus.Running => "RUNNING",
                EventsListResponseResultStatus.Succeeded => "SUCCEEDED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventsListResponseResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "FAILED" => EventsListResponseResultStatus.Failed,
                "PENDING" => EventsListResponseResultStatus.Pending,
                "RUNNING" => EventsListResponseResultStatus.Running,
                "SUCCEEDED" => EventsListResponseResultStatus.Succeeded,
                _ => null,
            };
        }
    }
}