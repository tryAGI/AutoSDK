//HintName: G.Models.UsageAudioTranscriptionsGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageAudioTranscriptionsGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectId,
        /// <summary>
        /// 
        /// </summary>
        UserId,
        /// <summary>
        /// 
        /// </summary>
        ApiKeyId,
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageAudioTranscriptionsGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageAudioTranscriptionsGroupByItem value)
        {
            return value switch
            {
                UsageAudioTranscriptionsGroupByItem.ProjectId => "project_id",
                UsageAudioTranscriptionsGroupByItem.UserId => "user_id",
                UsageAudioTranscriptionsGroupByItem.ApiKeyId => "api_key_id",
                UsageAudioTranscriptionsGroupByItem.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageAudioTranscriptionsGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "project_id" => UsageAudioTranscriptionsGroupByItem.ProjectId,
                "user_id" => UsageAudioTranscriptionsGroupByItem.UserId,
                "api_key_id" => UsageAudioTranscriptionsGroupByItem.ApiKeyId,
                "model" => UsageAudioTranscriptionsGroupByItem.Model,
                _ => null,
            };
        }
    }
}