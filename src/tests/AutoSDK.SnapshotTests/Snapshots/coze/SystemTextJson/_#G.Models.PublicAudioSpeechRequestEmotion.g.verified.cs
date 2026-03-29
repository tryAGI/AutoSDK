//HintName: G.Models.PublicAudioSpeechRequestEmotion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 情感，可选值 [none,happy,angry,sad,neutral]，默认 none
    /// </summary>
    public enum PublicAudioSpeechRequestEmotion
    {
        /// <summary>
        /// 
        /// </summary>
        Angry,
        /// <summary>
        /// 
        /// </summary>
        Coldness,
        /// <summary>
        /// 
        /// </summary>
        Excited,
        /// <summary>
        /// 
        /// </summary>
        Fear,
        /// <summary>
        /// 
        /// </summary>
        Happy,
        /// <summary>
        /// 
        /// </summary>
        Hate,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Sad,
        /// <summary>
        /// 
        /// </summary>
        Surprised,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicAudioSpeechRequestEmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicAudioSpeechRequestEmotion value)
        {
            return value switch
            {
                PublicAudioSpeechRequestEmotion.Angry => "angry",
                PublicAudioSpeechRequestEmotion.Coldness => "coldness",
                PublicAudioSpeechRequestEmotion.Excited => "excited",
                PublicAudioSpeechRequestEmotion.Fear => "fear",
                PublicAudioSpeechRequestEmotion.Happy => "happy",
                PublicAudioSpeechRequestEmotion.Hate => "hate",
                PublicAudioSpeechRequestEmotion.Neutral => "neutral",
                PublicAudioSpeechRequestEmotion.Sad => "sad",
                PublicAudioSpeechRequestEmotion.Surprised => "surprised",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicAudioSpeechRequestEmotion? ToEnum(string value)
        {
            return value switch
            {
                "angry" => PublicAudioSpeechRequestEmotion.Angry,
                "coldness" => PublicAudioSpeechRequestEmotion.Coldness,
                "excited" => PublicAudioSpeechRequestEmotion.Excited,
                "fear" => PublicAudioSpeechRequestEmotion.Fear,
                "happy" => PublicAudioSpeechRequestEmotion.Happy,
                "hate" => PublicAudioSpeechRequestEmotion.Hate,
                "neutral" => PublicAudioSpeechRequestEmotion.Neutral,
                "sad" => PublicAudioSpeechRequestEmotion.Sad,
                "surprised" => PublicAudioSpeechRequestEmotion.Surprised,
                _ => null,
            };
        }
    }
}