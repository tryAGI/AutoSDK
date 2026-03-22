//HintName: G.Models.RenderType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum RenderType2
    {
        /// <summary>
        /// 
        /// </summary>
        Aac,
        /// <summary>
        /// 
        /// </summary>
        Aaf,
        /// <summary>
        /// 
        /// </summary>
        ClipsZip,
        /// <summary>
        /// 
        /// </summary>
        Mp3,
        /// <summary>
        /// 
        /// </summary>
        Mp4,
        /// <summary>
        /// 
        /// </summary>
        TracksZip,
        /// <summary>
        /// 
        /// </summary>
        Wav,
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
                RenderType2.Aac => "aac",
                RenderType2.Aaf => "aaf",
                RenderType2.ClipsZip => "clips_zip",
                RenderType2.Mp3 => "mp3",
                RenderType2.Mp4 => "mp4",
                RenderType2.TracksZip => "tracks_zip",
                RenderType2.Wav => "wav",
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
                "aac" => RenderType2.Aac,
                "aaf" => RenderType2.Aaf,
                "clips_zip" => RenderType2.ClipsZip,
                "mp3" => RenderType2.Mp3,
                "mp4" => RenderType2.Mp4,
                "tracks_zip" => RenderType2.TracksZip,
                "wav" => RenderType2.Wav,
                _ => null,
            };
        }
    }
}