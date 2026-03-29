//HintName: G.Models.VapiVoicemailDetectionPlanProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider to use for voicemail detection.
    /// </summary>
    public enum VapiVoicemailDetectionPlanProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Vapi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VapiVoicemailDetectionPlanProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VapiVoicemailDetectionPlanProvider value)
        {
            return value switch
            {
                VapiVoicemailDetectionPlanProvider.Vapi => "vapi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VapiVoicemailDetectionPlanProvider? ToEnum(string value)
        {
            return value switch
            {
                "vapi" => VapiVoicemailDetectionPlanProvider.Vapi,
                _ => null,
            };
        }
    }
}