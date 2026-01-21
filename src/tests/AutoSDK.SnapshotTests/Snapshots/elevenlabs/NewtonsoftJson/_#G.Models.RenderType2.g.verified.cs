//HintName: G.Models.RenderType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RenderType2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp4")]
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aac")]
        Aac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3")]
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav")]
        Wav,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aaf")]
        Aaf,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tracks_zip")]
        TracksZip,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clips_zip")]
        ClipsZip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RenderType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenderType2 value)
        {
            return value switch
            {
                RenderType2.Mp4 => "mp4",
                RenderType2.Aac => "aac",
                RenderType2.Mp3 => "mp3",
                RenderType2.Wav => "wav",
                RenderType2.Aaf => "aaf",
                RenderType2.TracksZip => "tracks_zip",
                RenderType2.ClipsZip => "clips_zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenderType2? ToEnum(string value)
        {
            return value switch
            {
                "mp4" => RenderType2.Mp4,
                "aac" => RenderType2.Aac,
                "mp3" => RenderType2.Mp3,
                "wav" => RenderType2.Wav,
                "aaf" => RenderType2.Aaf,
                "tracks_zip" => RenderType2.TracksZip,
                "clips_zip" => RenderType2.ClipsZip,
                _ => null,
            };
        }
    }
}