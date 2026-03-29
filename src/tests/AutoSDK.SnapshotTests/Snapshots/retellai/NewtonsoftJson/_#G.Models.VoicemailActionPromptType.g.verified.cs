//HintName: G.Models.VoicemailActionPromptType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: prompt
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VoicemailActionPromptType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt")]
        Prompt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicemailActionPromptTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicemailActionPromptType value)
        {
            return value switch
            {
                VoicemailActionPromptType.Prompt => "prompt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicemailActionPromptType? ToEnum(string value)
        {
            return value switch
            {
                "prompt" => VoicemailActionPromptType.Prompt,
                _ => null,
            };
        }
    }
}