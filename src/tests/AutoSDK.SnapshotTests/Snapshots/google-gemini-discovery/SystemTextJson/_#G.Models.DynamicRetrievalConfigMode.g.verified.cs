//HintName: G.Models.DynamicRetrievalConfigMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The mode of the predictor to be used in dynamic retrieval.
    /// </summary>
    public enum DynamicRetrievalConfigMode
    {
        /// <summary>
        /// Run retrieval only when system decides it is necessary.
        /// </summary>
        ModeDynamic,
        /// <summary>
        /// Always trigger retrieval.
        /// </summary>
        ModeUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DynamicRetrievalConfigModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DynamicRetrievalConfigMode value)
        {
            return value switch
            {
                DynamicRetrievalConfigMode.ModeDynamic => "MODE_DYNAMIC",
                DynamicRetrievalConfigMode.ModeUnspecified => "MODE_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DynamicRetrievalConfigMode? ToEnum(string value)
        {
            return value switch
            {
                "MODE_DYNAMIC" => DynamicRetrievalConfigMode.ModeDynamic,
                "MODE_UNSPECIFIED" => DynamicRetrievalConfigMode.ModeUnspecified,
                _ => null,
            };
        }
    }
}