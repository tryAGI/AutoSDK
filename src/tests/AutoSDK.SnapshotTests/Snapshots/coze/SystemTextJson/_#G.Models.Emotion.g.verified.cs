//HintName: G.Models.Emotion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Emotion
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
    public static class EmotionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Emotion value)
        {
            return value switch
            {
                Emotion.Angry => "angry",
                Emotion.Coldness => "coldness",
                Emotion.Excited => "excited",
                Emotion.Fear => "fear",
                Emotion.Happy => "happy",
                Emotion.Hate => "hate",
                Emotion.Neutral => "neutral",
                Emotion.Sad => "sad",
                Emotion.Surprised => "surprised",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Emotion? ToEnum(string value)
        {
            return value switch
            {
                "angry" => Emotion.Angry,
                "coldness" => Emotion.Coldness,
                "excited" => Emotion.Excited,
                "fear" => Emotion.Fear,
                "happy" => Emotion.Happy,
                "hate" => Emotion.Hate,
                "neutral" => Emotion.Neutral,
                "sad" => Emotion.Sad,
                "surprised" => Emotion.Surprised,
                _ => null,
            };
        }
    }
}