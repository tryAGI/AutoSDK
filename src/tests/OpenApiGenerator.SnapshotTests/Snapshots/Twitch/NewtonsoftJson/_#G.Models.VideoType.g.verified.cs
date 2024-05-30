//HintName: G.Models.VideoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The video's type. Possible values are:  
    ///   
    /// * archive — An on-demand video (VOD) of one of the broadcaster's past streams.
    /// * highlight — A highlight reel of one of the broadcaster's past streams. See [Creating Highlights](https://help.twitch.tv/s/article/creating-highlights-and-stream-markers).
    /// * upload — A video that the broadcaster uploaded to their video library. See Upload under [Video Producer](https://help.twitch.tv/s/article/video-on-demand?language=en%5FUS#videoproducer).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VideoType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="archive")]
        Archive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="highlight")]
        Highlight,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="upload")]
        Upload,
    }

    public static class VideoTypeExtensions
    {
        public static string ToValueString(this VideoType value)
        {
            return value switch
            {
                VideoType.Archive => "archive",
                VideoType.Highlight => "highlight",
                VideoType.Upload => "upload",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VideoType ToEnum(string value)
        {
            return value switch
            {
                "archive" => VideoType.Archive,
                "highlight" => VideoType.Highlight,
                "upload" => VideoType.Upload,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static VideoType ToEnum(int value)
        {
            return value switch
            {
                0 => VideoType.Archive,
                1 => VideoType.Highlight,
                2 => VideoType.Upload,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}