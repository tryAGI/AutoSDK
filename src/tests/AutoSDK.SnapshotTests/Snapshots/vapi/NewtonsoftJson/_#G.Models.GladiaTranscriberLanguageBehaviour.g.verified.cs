//HintName: G.Models.GladiaTranscriberLanguageBehaviour.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GladiaTranscriberLanguageBehaviour
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
    public static class GladiaTranscriberLanguageBehaviourExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GladiaTranscriberLanguageBehaviour value)
        {
            return value switch
            {
                GladiaTranscriberLanguageBehaviour.AutomaticMultipleLanguages => "automatic multiple languages",
                GladiaTranscriberLanguageBehaviour.AutomaticSingleLanguage => "automatic single language",
                GladiaTranscriberLanguageBehaviour.Manual => "manual",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GladiaTranscriberLanguageBehaviour? ToEnum(string value)
        {
            return value switch
            {
                "automatic multiple languages" => GladiaTranscriberLanguageBehaviour.AutomaticMultipleLanguages,
                "automatic single language" => GladiaTranscriberLanguageBehaviour.AutomaticSingleLanguage,
                "manual" => GladiaTranscriberLanguageBehaviour.Manual,
                _ => null,
            };
        }
    }
}