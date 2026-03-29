//HintName: G.Models.PillarScanParametersScanner.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PillarScanParametersScanner
    {
        /// <summary>
        /// 
        /// </summary>
        InvisibleCharacters,
        /// <summary>
        /// 
        /// </summary>
        Pii,
        /// <summary>
        /// 
        /// </summary>
        PromptInjection,
        /// <summary>
        /// 
        /// </summary>
        Secrets,
        /// <summary>
        /// 
        /// </summary>
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