//HintName: G.Models.FallbackGladiaTranscriberLanguageBehaviour.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackGladiaTranscriberLanguageBehaviour
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automatic multiple languages")]
        AutomaticMultipleLanguages,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="automatic single language")]
        AutomaticSingleLanguage,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="manual")]
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