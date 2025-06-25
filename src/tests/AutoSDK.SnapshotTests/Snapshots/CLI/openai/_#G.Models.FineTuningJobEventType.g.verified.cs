//HintName: G.Models.FineTuningJobEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of event.
    /// </summary>
    public enum FineTuningJobEventType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
        /// <summary>
        /// 
        /// </summary>
        Metrics,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuningJobEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuningJobEventType value)
        {
            return value switch
            {
                FineTuningJobEventType.Message => "message",
                FineTuningJobEventType.Metrics => "metrics",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuningJobEventType? ToEnum(string value)
        {
            return value switch
            {
                "message" => FineTuningJobEventType.Message,
                "metrics" => FineTuningJobEventType.Metrics,
                _ => null,
            };
        }
    }
}