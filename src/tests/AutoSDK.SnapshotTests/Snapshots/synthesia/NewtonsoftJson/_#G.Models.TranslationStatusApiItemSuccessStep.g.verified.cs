//HintName: G.Models.TranslationStatusApiItemSuccessStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TranslationStatusApiItemSuccessStep
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="generation")]
        Generation,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translation")]
        Translation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranslationStatusApiItemSuccessStepExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranslationStatusApiItemSuccessStep value)
        {
            return value switch
            {
                TranslationStatusApiItemSuccessStep.Generation => "generation",
                TranslationStatusApiItemSuccessStep.Translation => "translation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranslationStatusApiItemSuccessStep? ToEnum(string value)
        {
            return value switch
            {
                "generation" => TranslationStatusApiItemSuccessStep.Generation,
                "translation" => TranslationStatusApiItemSuccessStep.Translation,
                _ => null,
            };
        }
    }
}