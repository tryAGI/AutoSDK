//HintName: G.Models.AgentRequestVoiceEmotion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Controls the emotional tone of the agent's voice. Currently supported for Cartesia and Minimax TTS providers. If unset, no emotion will be used.<br/>
    /// Example: calm
    /// </summary>
    public enum AgentRequestVoiceEmotion
    {
        /// <summary>
        /// 
        /// </summary>
        Angry,
        /// <summary>
        /// 
        /// </summary>
        Calm,
        /// <summary>
        /// 
        /// </summary>
        Fearful,
        /// <summary>
        /// 
        /// </summary>
        Happy,
        /// <summary>
        /// 
        /// </summary>
        OpenapiJsonNullSentinelValue2bf936000fe44250987aE5ddb203e464,
        /// <summary>
        /// 
        /// </summary>
        Sad,
        /// <summary>
        /// 
        /// </summary>
        Surprised,
        /// <summary>
        /// 
        /// </summary>
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