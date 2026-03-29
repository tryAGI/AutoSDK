//HintName: G.Models.FallbackElevenLabsVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FallbackElevenLabsVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="andrea")]
        Andrea,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="burt")]
        Burt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="drew")]
        Drew,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="joseph")]
        Joseph,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="marissa")]
        Marissa,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mark")]
        Mark,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="matilda")]
        Matilda,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mrb")]
        Mrb,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="myra")]
        Myra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="paul")]
        Paul,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="paula")]
        Paula,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phillip")]
        Phillip,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ryan")]
        Ryan,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="sarah")]
        Sarah,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="steve")]
        Steve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackElevenLabsVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackElevenLabsVoiceVoiceId value)
        {
            return value switch
            {
                FallbackElevenLabsVoiceVoiceId.Andrea => "andrea",
                FallbackElevenLabsVoiceVoiceId.Burt => "burt",
                FallbackElevenLabsVoiceVoiceId.Drew => "drew",
                FallbackElevenLabsVoiceVoiceId.Joseph => "joseph",
                FallbackElevenLabsVoiceVoiceId.Marissa => "marissa",
                FallbackElevenLabsVoiceVoiceId.Mark => "mark",
                FallbackElevenLabsVoiceVoiceId.Matilda => "matilda",
                FallbackElevenLabsVoiceVoiceId.Mrb => "mrb",
                FallbackElevenLabsVoiceVoiceId.Myra => "myra",
                FallbackElevenLabsVoiceVoiceId.Paul => "paul",
                FallbackElevenLabsVoiceVoiceId.Paula => "paula",
                FallbackElevenLabsVoiceVoiceId.Phillip => "phillip",
                FallbackElevenLabsVoiceVoiceId.Ryan => "ryan",
                FallbackElevenLabsVoiceVoiceId.Sarah => "sarah",
                FallbackElevenLabsVoiceVoiceId.Steve => "steve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackElevenLabsVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "andrea" => FallbackElevenLabsVoiceVoiceId.Andrea,
                "burt" => FallbackElevenLabsVoiceVoiceId.Burt,
                "drew" => FallbackElevenLabsVoiceVoiceId.Drew,
                "joseph" => FallbackElevenLabsVoiceVoiceId.Joseph,
                "marissa" => FallbackElevenLabsVoiceVoiceId.Marissa,
                "mark" => FallbackElevenLabsVoiceVoiceId.Mark,
                "matilda" => FallbackElevenLabsVoiceVoiceId.Matilda,
                "mrb" => FallbackElevenLabsVoiceVoiceId.Mrb,
                "myra" => FallbackElevenLabsVoiceVoiceId.Myra,
                "paul" => FallbackElevenLabsVoiceVoiceId.Paul,
                "paula" => FallbackElevenLabsVoiceVoiceId.Paula,
                "phillip" => FallbackElevenLabsVoiceVoiceId.Phillip,
                "ryan" => FallbackElevenLabsVoiceVoiceId.Ryan,
                "sarah" => FallbackElevenLabsVoiceVoiceId.Sarah,
                "steve" => FallbackElevenLabsVoiceVoiceId.Steve,
                _ => null,
            };
        }
    }
}