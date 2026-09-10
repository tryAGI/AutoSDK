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
        [global::System.Runtime.Serialization.EnumMember(Value="aac")]
        Aac,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aaf")]
        Aaf,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clips_zip")]
        ClipsZip,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp3")]
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mp4")]
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tracks_zip")]
        TracksZip,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="wav")]
        Wav,
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
                RenderType.Aac => "aac",
                RenderType.Aaf => "aaf",
                RenderType.ClipsZip => "clips_zip",
                RenderType.Mp3 => "mp3",
                RenderType.Mp4 => "mp4",
                RenderType.TracksZip => "tracks_zip",
                RenderType.Wav => "wav",
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
                "aac" => RenderType.Aac,
                "aaf" => RenderType.Aaf,
                "clips_zip" => RenderType.ClipsZip,
                "mp3" => RenderType.Mp3,
                "mp4" => RenderType.Mp4,
                "tracks_zip" => RenderType.TracksZip,
                "wav" => RenderType.Wav,
                _ => null,
            };
        }
    }
}