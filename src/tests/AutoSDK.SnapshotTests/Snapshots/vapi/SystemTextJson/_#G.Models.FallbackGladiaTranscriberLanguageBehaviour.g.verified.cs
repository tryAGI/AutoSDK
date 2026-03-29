//HintName: G.Models.FallbackGladiaTranscriberLanguageBehaviour.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FallbackGladiaTranscriberLanguageBehaviour
    {
        /// <summary>
        /// 
        /// </summary>
        AutomaticMultipleLanguages,
        /// <summary>
        /// 
        /// </summary>
        AutomaticSingleLanguage,
        /// <summary>
        /// 
        /// </summary>
        Manual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackGladiaTranscriberLanguageBehaviourExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackGladiaTranscriberLanguageBehaviour value)
        {
            return value switch
            {
                FallbackGladiaTranscriberLanguageBehaviour.AutomaticMultipleLanguages => "automatic multiple languages",
                FallbackGladiaTranscriberLanguageBehaviour.AutomaticSingleLanguage => "automatic single language",
                FallbackGladiaTranscriberLanguageBehaviour.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackGladiaTranscriberLanguageBehaviour? ToEnum(string value)
        {
            return value switch
            {
                "automatic multiple languages" => FallbackGladiaTranscriberLanguageBehaviour.AutomaticMultipleLanguages,
                "automatic single language" => FallbackGladiaTranscriberLanguageBehaviour.AutomaticSingleLanguage,
                "manual" => FallbackGladiaTranscriberLanguageBehaviour.Manual,
                _ => null,
            };
        }
    }
}