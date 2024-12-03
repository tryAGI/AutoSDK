//HintName: G.Models.FineTuneEventObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FineTuneEventObject
    {
        /// <summary>
        /// 
        /// </summary>
        FineTuneEvent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FineTuneEventObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FineTuneEventObject value)
        {
            return value switch
            {
                FineTuneEventObject.FineTuneEvent => "fine-tune-event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FineTuneEventObject? ToEnum(string value)
        {
            return value switch
            {
                "fine-tune-event" => FineTuneEventObject.FineTuneEvent,
                _ => null,
            };
        }
    }
}