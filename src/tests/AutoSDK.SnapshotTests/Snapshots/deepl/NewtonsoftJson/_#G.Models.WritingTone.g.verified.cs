//HintName: G.Models.WritingTone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specify the desired tone for your text.<br/>
    /// The `prefer_` prefix allows falling back to the default tone if the language does not yet support tones.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WritingTone
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="confident")]
        Confident,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="diplomatic")]
        Diplomatic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enthusiastic")]
        Enthusiastic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="friendly")]
        Friendly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prefer_confident")]
        PreferConfident,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prefer_diplomatic")]
        PreferDiplomatic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prefer_enthusiastic")]
        PreferEnthusiastic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prefer_friendly")]
        PreferFriendly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WritingToneExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WritingTone value)
        {
            return value switch
            {
                WritingTone.Confident => "confident",
                WritingTone.Default => "default",
                WritingTone.Diplomatic => "diplomatic",
                WritingTone.Enthusiastic => "enthusiastic",
                WritingTone.Friendly => "friendly",
                WritingTone.PreferConfident => "prefer_confident",
                WritingTone.PreferDiplomatic => "prefer_diplomatic",
                WritingTone.PreferEnthusiastic => "prefer_enthusiastic",
                WritingTone.PreferFriendly => "prefer_friendly",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WritingTone? ToEnum(string value)
        {
            return value switch
            {
                "confident" => WritingTone.Confident,
                "default" => WritingTone.Default,
                "diplomatic" => WritingTone.Diplomatic,
                "enthusiastic" => WritingTone.Enthusiastic,
                "friendly" => WritingTone.Friendly,
                "prefer_confident" => WritingTone.PreferConfident,
                "prefer_diplomatic" => WritingTone.PreferDiplomatic,
                "prefer_enthusiastic" => WritingTone.PreferEnthusiastic,
                "prefer_friendly" => WritingTone.PreferFriendly,
                _ => null,
            };
        }
    }
}