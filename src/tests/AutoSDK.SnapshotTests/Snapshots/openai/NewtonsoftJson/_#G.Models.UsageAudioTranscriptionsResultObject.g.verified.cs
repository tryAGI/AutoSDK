//HintName: G.Models.UsageAudioTranscriptionsResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageAudioTranscriptionsResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization.usage.audio_transcriptions.result")]
        OrganizationUsageAudioTranscriptionsResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageAudioTranscriptionsResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageAudioTranscriptionsResultObject value)
        {
            return value switch
            {
                UsageAudioTranscriptionsResultObject.OrganizationUsageAudioTranscriptionsResult => "organization.usage.audio_transcriptions.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageAudioTranscriptionsResultObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.usage.audio_transcriptions.result" => UsageAudioTranscriptionsResultObject.OrganizationUsageAudioTranscriptionsResult,
                _ => null,
            };
        }
    }
}