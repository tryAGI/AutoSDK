//HintName: G.Models.VoicemailDetectionCostProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider that was used to detect the voicemail.
    /// </summary>
    public enum VoicemailDetectionCostProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Google,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Twilio,
        /// <summary>
        /// 
        /// </summary>
        Vapi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VoicemailDetectionCostProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VoicemailDetectionCostProvider value)
        {
            return value switch
            {
                VoicemailDetectionCostProvider.Google => "google",
                VoicemailDetectionCostProvider.Openai => "openai",
                VoicemailDetectionCostProvider.Twilio => "twilio",
                VoicemailDetectionCostProvider.Vapi => "vapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VoicemailDetectionCostProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => VoicemailDetectionCostProvider.Google,
                "openai" => VoicemailDetectionCostProvider.Openai,
                "twilio" => VoicemailDetectionCostProvider.Twilio,
                "vapi" => VoicemailDetectionCostProvider.Vapi,
                _ => null,
            };
        }
    }
}