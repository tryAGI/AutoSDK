//HintName: G.Models.AssemblyAITranscriberLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the language that will be set for the transcription.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssemblyAITranscriberLanguage
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
    public static class AssemblyAITranscriberLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssemblyAITranscriberLanguage value)
        {
            return value switch
            {
                AssemblyAITranscriberLanguage.En => "en",
                AssemblyAITranscriberLanguage.Multi => "multi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssemblyAITranscriberLanguage? ToEnum(string value)
        {
            return value switch
            {
                "en" => AssemblyAITranscriberLanguage.En,
                "multi" => AssemblyAITranscriberLanguage.Multi,
                _ => null,
            };
        }
    }
}