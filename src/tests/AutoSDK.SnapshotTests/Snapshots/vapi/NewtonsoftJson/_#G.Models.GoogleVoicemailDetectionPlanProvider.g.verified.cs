//HintName: G.Models.GoogleVoicemailDetectionPlanProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider to use for voicemail detection.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoogleVoicemailDetectionPlanProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GoogleVoicemailDetectionPlanProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleVoicemailDetectionPlanProvider value)
        {
            return value switch
            {
                GoogleVoicemailDetectionPlanProvider.Google => "google",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleVoicemailDetectionPlanProvider? ToEnum(string value)
        {
            return value switch
            {
                "google" => GoogleVoicemailDetectionPlanProvider.Google,
                _ => null,
            };
        }
    }
}