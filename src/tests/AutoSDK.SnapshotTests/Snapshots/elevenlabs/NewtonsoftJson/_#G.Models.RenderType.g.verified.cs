//HintName: G.Models.RenderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RenderType
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
    public static class RenderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RenderType value)
        {
            return value switch
            {
                RenderType.Mp4 => "mp4",
                RenderType.Aac => "aac",
                RenderType.Mp3 => "mp3",
                RenderType.Wav => "wav",
                RenderType.Aaf => "aaf",
                RenderType.TracksZip => "tracks_zip",
                RenderType.ClipsZip => "clips_zip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RenderType? ToEnum(string value)
        {
            return value switch
            {
                "mp4" => RenderType.Mp4,
                "aac" => RenderType.Aac,
                "mp3" => RenderType.Mp3,
                "wav" => RenderType.Wav,
                "aaf" => RenderType.Aaf,
                "tracks_zip" => RenderType.TracksZip,
                "clips_zip" => RenderType.ClipsZip,
                _ => null,
            };
        }
    }
}