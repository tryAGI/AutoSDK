//HintName: G.Models.WaitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the event type. For a wait action, this property is <br/>
    /// always set to `wait`.<br/>
    /// Default Value: wait
    /// </summary>
    public enum WaitType
    {
        /// <summary>
        /// 
        /// </summary>
        Wait,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WaitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WaitType value)
        {
            return value switch
            {
                WaitType.Wait => "wait",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WaitType? ToEnum(string value)
        {
            return value switch
            {
                "wait" => WaitType.Wait,
                _ => null,
            };
        }
    }
}