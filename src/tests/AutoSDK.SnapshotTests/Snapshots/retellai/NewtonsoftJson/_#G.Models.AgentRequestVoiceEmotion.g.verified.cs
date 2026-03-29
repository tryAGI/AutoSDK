//HintName: G.Models.AgentRequestVoiceEmotion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls the emotional tone of the agent's voice. Currently supported for Cartesia and Minimax TTS providers. If unset, no emotion will be used.<br/>
    /// Example: calm
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentRequestVoiceEmotion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="angry")]
        Angry,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="calm")]
        Calm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fearful")]
        Fearful,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="happy")]
        Happy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464")]
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sad")]
        Sad,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="surprised")]
        Surprised,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sympathetic")]
        Sympathetic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentRequestVoiceEmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentRequestVoiceEmotion value)
        {
            return value switch
            {
                AgentRequestVoiceEmotion.Angry => "angry",
                AgentRequestVoiceEmotion.Calm => "calm",
                AgentRequestVoiceEmotion.Fearful => "fearful",
                AgentRequestVoiceEmotion.Happy => "happy",
                AgentRequestVoiceEmotion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464 => "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464",
                AgentRequestVoiceEmotion.Sad => "sad",
                AgentRequestVoiceEmotion.Surprised => "surprised",
                AgentRequestVoiceEmotion.Sympathetic => "sympathetic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentRequestVoiceEmotion? ToEnum(string value)
        {
            return value switch
            {
                "angry" => AgentRequestVoiceEmotion.Angry,
                "calm" => AgentRequestVoiceEmotion.Calm,
                "fearful" => AgentRequestVoiceEmotion.Fearful,
                "happy" => AgentRequestVoiceEmotion.Happy,
                "openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464" => AgentRequestVoiceEmotion.OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
                "sad" => AgentRequestVoiceEmotion.Sad,
                "surprised" => AgentRequestVoiceEmotion.Surprised,
                "sympathetic" => AgentRequestVoiceEmotion.Sympathetic,
                _ => null,
            };
        }
    }
}