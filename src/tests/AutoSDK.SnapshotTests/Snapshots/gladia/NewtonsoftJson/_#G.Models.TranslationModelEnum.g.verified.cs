//HintName: G.Models.TranslationModelEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model you want the translation model to use to translate
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslationModelEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base")]
        Base,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enhanced")]
        Enhanced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationModelEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationModelEnum value)
        {
            return value switch
            {
                TranslationModelEnum.Base => "base",
                TranslationModelEnum.Enhanced => "enhanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationModelEnum? ToEnum(string value)
        {
            return value switch
            {
                "base" => TranslationModelEnum.Base,
                "enhanced" => TranslationModelEnum.Enhanced,
                _ => null,
            };
        }
    }
}