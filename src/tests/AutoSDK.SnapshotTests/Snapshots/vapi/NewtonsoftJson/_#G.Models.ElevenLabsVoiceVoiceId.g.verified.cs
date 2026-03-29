//HintName: G.Models.ElevenLabsVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ElevenLabsVoiceVoiceId
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
    public static class ElevenLabsVoiceVoiceIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElevenLabsVoiceVoiceId value)
        {
            return value switch
            {
                ElevenLabsVoiceVoiceId.Andrea => "andrea",
                ElevenLabsVoiceVoiceId.Burt => "burt",
                ElevenLabsVoiceVoiceId.Drew => "drew",
                ElevenLabsVoiceVoiceId.Joseph => "joseph",
                ElevenLabsVoiceVoiceId.Marissa => "marissa",
                ElevenLabsVoiceVoiceId.Mark => "mark",
                ElevenLabsVoiceVoiceId.Matilda => "matilda",
                ElevenLabsVoiceVoiceId.Mrb => "mrb",
                ElevenLabsVoiceVoiceId.Myra => "myra",
                ElevenLabsVoiceVoiceId.Paul => "paul",
                ElevenLabsVoiceVoiceId.Paula => "paula",
                ElevenLabsVoiceVoiceId.Phillip => "phillip",
                ElevenLabsVoiceVoiceId.Ryan => "ryan",
                ElevenLabsVoiceVoiceId.Sarah => "sarah",
                ElevenLabsVoiceVoiceId.Steve => "steve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElevenLabsVoiceVoiceId? ToEnum(string value)
        {
            return value switch
            {
                "andrea" => ElevenLabsVoiceVoiceId.Andrea,
                "burt" => ElevenLabsVoiceVoiceId.Burt,
                "drew" => ElevenLabsVoiceVoiceId.Drew,
                "joseph" => ElevenLabsVoiceVoiceId.Joseph,
                "marissa" => ElevenLabsVoiceVoiceId.Marissa,
                "mark" => ElevenLabsVoiceVoiceId.Mark,
                "matilda" => ElevenLabsVoiceVoiceId.Matilda,
                "mrb" => ElevenLabsVoiceVoiceId.Mrb,
                "myra" => ElevenLabsVoiceVoiceId.Myra,
                "paul" => ElevenLabsVoiceVoiceId.Paul,
                "paula" => ElevenLabsVoiceVoiceId.Paula,
                "phillip" => ElevenLabsVoiceVoiceId.Phillip,
                "ryan" => ElevenLabsVoiceVoiceId.Ryan,
                "sarah" => ElevenLabsVoiceVoiceId.Sarah,
                "steve" => ElevenLabsVoiceVoiceId.Steve,
                _ => null,
            };
        }
    }
}