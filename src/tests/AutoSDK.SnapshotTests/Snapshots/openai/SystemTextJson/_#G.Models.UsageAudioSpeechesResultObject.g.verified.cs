//HintName: G.Models.UsageAudioSpeechesResultObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageAudioSpeechesResultObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationUsageAudioSpeechesResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageAudioSpeechesResultObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageAudioSpeechesResultObject value)
        {
            return value switch
            {
                UsageAudioSpeechesResultObject.OrganizationUsageAudioSpeechesResult => "organization.usage.audio_speeches.result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageAudioSpeechesResultObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.usage.audio_speeches.result" => UsageAudioSpeechesResultObject.OrganizationUsageAudioSpeechesResult,
                _ => null,
            };
        }
    }
}