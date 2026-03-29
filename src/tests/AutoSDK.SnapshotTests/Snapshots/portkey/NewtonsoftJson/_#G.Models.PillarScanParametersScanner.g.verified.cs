//HintName: G.Models.PillarScanParametersScanner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PillarScanParametersScanner
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="invisible_characters")]
        InvisibleCharacters,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pii")]
        Pii,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt_injection")]
        PromptInjection,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="secrets")]
        Secrets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="toxic_language")]
        ToxicLanguage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PillarScanParametersScannerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PillarScanParametersScanner value)
        {
            return value switch
            {
                PillarScanParametersScanner.InvisibleCharacters => "invisible_characters",
                PillarScanParametersScanner.Pii => "pii",
                PillarScanParametersScanner.PromptInjection => "prompt_injection",
                PillarScanParametersScanner.Secrets => "secrets",
                PillarScanParametersScanner.ToxicLanguage => "toxic_language",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PillarScanParametersScanner? ToEnum(string value)
        {
            return value switch
            {
                "invisible_characters" => PillarScanParametersScanner.InvisibleCharacters,
                "pii" => PillarScanParametersScanner.Pii,
                "prompt_injection" => PillarScanParametersScanner.PromptInjection,
                "secrets" => PillarScanParametersScanner.Secrets,
                "toxic_language" => PillarScanParametersScanner.ToxicLanguage,
                _ => null,
            };
        }
    }
}