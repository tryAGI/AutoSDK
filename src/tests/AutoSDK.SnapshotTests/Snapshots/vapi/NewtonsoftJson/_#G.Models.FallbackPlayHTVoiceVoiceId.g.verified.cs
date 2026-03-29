//HintName: G.Models.FallbackPlayHTVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackPlayHTVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chris")]
        Chris,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="davis")]
        Davis,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="donna")]
        Donna,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jack")]
        Jack,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jennifer")]
        Jennifer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="matt")]
        Matt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="melissa")]
        Melissa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="michael")]
        Michael,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ruby")]
        Ruby,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="will")]
        Will,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackPlayHTVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackPlayHTVoiceVoiceId value)
        {
            return value switch
            {
                FallbackPlayHTVoiceVoiceId.Chris => "chris",
                FallbackPlayHTVoiceVoiceId.Davis => "davis",
                FallbackPlayHTVoiceVoiceId.Donna => "donna",
                FallbackPlayHTVoiceVoiceId.Jack => "jack",
                FallbackPlayHTVoiceVoiceId.Jennifer => "jennifer",
                FallbackPlayHTVoiceVoiceId.Matt => "matt",
                FallbackPlayHTVoiceVoiceId.Melissa => "melissa",
                FallbackPlayHTVoiceVoiceId.Michael => "michael",
                FallbackPlayHTVoiceVoiceId.Ruby => "ruby",
                FallbackPlayHTVoiceVoiceId.Will => "will",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackPlayHTVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "chris" => FallbackPlayHTVoiceVoiceId.Chris,
                "davis" => FallbackPlayHTVoiceVoiceId.Davis,
                "donna" => FallbackPlayHTVoiceVoiceId.Donna,
                "jack" => FallbackPlayHTVoiceVoiceId.Jack,
                "jennifer" => FallbackPlayHTVoiceVoiceId.Jennifer,
                "matt" => FallbackPlayHTVoiceVoiceId.Matt,
                "melissa" => FallbackPlayHTVoiceVoiceId.Melissa,
                "michael" => FallbackPlayHTVoiceVoiceId.Michael,
                "ruby" => FallbackPlayHTVoiceVoiceId.Ruby,
                "will" => FallbackPlayHTVoiceVoiceId.Will,
                _ => null,
            };
        }
    }
}