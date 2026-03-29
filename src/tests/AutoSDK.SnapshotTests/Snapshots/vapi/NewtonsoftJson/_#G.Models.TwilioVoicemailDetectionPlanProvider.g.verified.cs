//HintName: G.Models.TwilioVoicemailDetectionPlanProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider to use for voicemail detection.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TwilioVoicemailDetectionPlanProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="twilio")]
        Twilio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TwilioVoicemailDetectionPlanProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TwilioVoicemailDetectionPlanProvider value)
        {
            return value switch
            {
                TwilioVoicemailDetectionPlanProvider.Twilio => "twilio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TwilioVoicemailDetectionPlanProvider? ToEnum(string value)
        {
            return value switch
            {
                "twilio" => TwilioVoicemailDetectionPlanProvider.Twilio,
                _ => null,
            };
        }
    }
}