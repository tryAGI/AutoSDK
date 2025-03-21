//HintName: G.Models.RefusalType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the refusal. Always `refusal`.
    /// </summary>
    public enum RefusalType
    {
        /// <summary>
        /// 
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RefusalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RefusalType value)
        {
            return value switch
            {
                RefusalType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RefusalType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => RefusalType.Refusal,
                _ => null,
            };
        }
    }
}