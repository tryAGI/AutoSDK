//HintName: G.Models.UsageAudioSpeechesGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UsageAudioSpeechesGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKeyId,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        ProjectId,
        /// <summary>
        /// 
        /// </summary>
        UserId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsageAudioSpeechesGroupByItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsageAudioSpeechesGroupByItem value)
        {
            return value switch
            {
                UsageAudioSpeechesGroupByItem.ApiKeyId => "api_key_id",
                UsageAudioSpeechesGroupByItem.Model => "model",
                UsageAudioSpeechesGroupByItem.ProjectId => "project_id",
                UsageAudioSpeechesGroupByItem.UserId => "user_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsageAudioSpeechesGroupByItem? ToEnum(string value)
        {
            return value switch
            {
                "api_key_id" => UsageAudioSpeechesGroupByItem.ApiKeyId,
                "model" => UsageAudioSpeechesGroupByItem.Model,
                "project_id" => UsageAudioSpeechesGroupByItem.ProjectId,
                "user_id" => UsageAudioSpeechesGroupByItem.UserId,
                _ => null,
            };
        }
    }
}