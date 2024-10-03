//HintName: G.Models.FTModelCardType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: fine-tuned
    /// </summary>
    public enum FTModelCardType
    {
        /// <summary>
        /// 
        /// </summary>
        FineTuned,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FTModelCardTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FTModelCardType value)
        {
            return value switch
            {
                FTModelCardType.FineTuned => "fine-tuned",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FTModelCardType? ToEnum(string value)
        {
            return value switch
            {
                "fine-tuned" => FTModelCardType.FineTuned,
                _ => null,
            };
        }
    }
}