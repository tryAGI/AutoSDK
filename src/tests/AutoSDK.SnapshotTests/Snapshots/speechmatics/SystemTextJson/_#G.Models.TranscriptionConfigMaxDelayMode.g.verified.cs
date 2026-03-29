//HintName: G.Models.TranscriptionConfigMaxDelayMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether or not to enable flexible endpointing and allow the entity to continue to be spoken.
    /// </summary>
    public enum TranscriptionConfigMaxDelayMode
    {
        /// <summary>
        /// 
        /// </summary>
        Fixed,
        /// <summary>
        /// 
        /// </summary>
        Flexible,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionConfigMaxDelayModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionConfigMaxDelayMode value)
        {
            return value switch
            {
                TranscriptionConfigMaxDelayMode.Fixed => "fixed",
                TranscriptionConfigMaxDelayMode.Flexible => "flexible",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionConfigMaxDelayMode? ToEnum(string value)
        {
            return value switch
            {
                "fixed" => TranscriptionConfigMaxDelayMode.Fixed,
                "flexible" => TranscriptionConfigMaxDelayMode.Flexible,
                _ => null,
            };
        }
    }
}