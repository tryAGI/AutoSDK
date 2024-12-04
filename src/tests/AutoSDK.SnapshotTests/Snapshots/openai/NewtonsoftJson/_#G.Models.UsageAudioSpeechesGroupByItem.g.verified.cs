//HintName: G.Models.UsageAudioSpeechesGroupByItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UsageAudioSpeechesGroupByItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project_id")]
        ProjectId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user_id")]
        UserId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_key_id")]
        ApiKeyId,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="model")]
        Model,
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
                UsageAudioSpeechesGroupByItem.ProjectId => "project_id",
                UsageAudioSpeechesGroupByItem.UserId => "user_id",
                UsageAudioSpeechesGroupByItem.ApiKeyId => "api_key_id",
                UsageAudioSpeechesGroupByItem.Model => "model",
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
                "project_id" => UsageAudioSpeechesGroupByItem.ProjectId,
                "user_id" => UsageAudioSpeechesGroupByItem.UserId,
                "api_key_id" => UsageAudioSpeechesGroupByItem.ApiKeyId,
                "model" => UsageAudioSpeechesGroupByItem.Model,
                _ => null,
            };
        }
    }
}