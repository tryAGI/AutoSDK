//HintName: G.Models.Emotion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Emotion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="angry")]
        Angry,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="coldness")]
        Coldness,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="excited")]
        Excited,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fear")]
        Fear,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="happy")]
        Happy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hate")]
        Hate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
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