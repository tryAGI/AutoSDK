//HintName: G.Models.TranslationToolType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool.
    /// </summary>
    public enum TranslationToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Translation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationToolType value)
        {
            return value switch
            {
                TranslationToolType.Translation => "translation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationToolType? ToEnum(string value)
        {
            return value switch
            {
                "translation" => TranslationToolType.Translation,
                _ => null,
            };
        }
    }
}