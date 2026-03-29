//HintName: G.Models.FallbackAssemblyAITranscriberLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the language that will be set for the transcription.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackAssemblyAITranscriberLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="en")]
        En,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="multi")]
        Multi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackAssemblyAITranscriberLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackAssemblyAITranscriberLanguage value)
        {
            return value switch
            {
                FallbackAssemblyAITranscriberLanguage.En => "en",
                FallbackAssemblyAITranscriberLanguage.Multi => "multi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackAssemblyAITranscriberLanguage? ToEnum(string value)
        {
            return value switch
            {
                "en" => FallbackAssemblyAITranscriberLanguage.En,
                "multi" => FallbackAssemblyAITranscriberLanguage.Multi,
                _ => null,
            };
        }
    }
}