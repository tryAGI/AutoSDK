//HintName: G.Models.ElevenLabsVoiceVoiceId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ElevenLabsVoiceVoiceId
    {
        /// <summary>
        /// 
        /// </summary>
        Andrea,
        /// <summary>
        /// 
        /// </summary>
        Burt,
        /// <summary>
        /// 
        /// </summary>
        Drew,
        /// <summary>
        /// 
        /// </summary>
        Joseph,
        /// <summary>
        /// 
        /// </summary>
        Marissa,
        /// <summary>
        /// 
        /// </summary>
        Mark,
        /// <summary>
        /// 
        /// </summary>
        Matilda,
        /// <summary>
        /// 
        /// </summary>
        Mrb,
        /// <summary>
        /// 
        /// </summary>
        Myra,
        /// <summary>
        /// 
        /// </summary>
        Paul,
        /// <summary>
        /// 
        /// </summary>
        Paula,
        /// <summary>
        /// 
        /// </summary>
        Phillip,
        /// <summary>
        /// 
        /// </summary>
        Ryan,
        /// <summary>
        /// 
        /// </summary>
        Sarah,
        /// <summary>
        /// 
        /// </summary>
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