//HintName: G.Models.FineTuneEventObject2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneEventObject2
    {
        /// <summary>
        /// 
        /// </summary>
        FineTuneEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneEventObject2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneEventObject2 value)
        {
            return value switch
            {
                FineTuneEventObject2.FineTuneEvent => "fine-tune-event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneEventObject2? ToEnum(string value)
        {
            return value switch
            {
                "fine-tune-event" => FineTuneEventObject2.FineTuneEvent,
                _ => null,
            };
        }
    }
}