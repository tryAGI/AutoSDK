//HintName: G.Models.TranslationStatusApiItemErrorStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: error
    /// </summary>
    public enum TranslationStatusApiItemErrorStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationStatusApiItemErrorStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationStatusApiItemErrorStatus value)
        {
            return value switch
            {
                TranslationStatusApiItemErrorStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationStatusApiItemErrorStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => TranslationStatusApiItemErrorStatus.Error,
                _ => null,
            };
        }
    }
}