//HintName: G.Models.OpenAIVoicemailDetectionPlanProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider to use for voicemail detection.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenAIVoicemailDetectionPlanProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai")]
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenAIVoicemailDetectionPlanProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenAIVoicemailDetectionPlanProvider value)
        {
            return value switch
            {
                OpenAIVoicemailDetectionPlanProvider.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenAIVoicemailDetectionPlanProvider? ToEnum(string value)
        {
            return value switch
            {
                "openai" => OpenAIVoicemailDetectionPlanProvider.Openai,
                _ => null,
            };
        }
    }
}