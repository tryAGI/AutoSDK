//HintName: G.Models.TranslationMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: translation<br/>
    /// Example: translation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslationMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation")]
        Translation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationMessageType value)
        {
            return value switch
            {
                TranslationMessageType.Translation => "translation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationMessageType? ToEnum(string value)
        {
            return value switch
            {
                "translation" => TranslationMessageType.Translation,
                _ => null,
            };
        }
    }
}