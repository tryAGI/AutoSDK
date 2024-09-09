//HintName: G.Models.VideoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The video's type. Possible values are:  <br/>
    ///   <br/>
    /// * archive — An on-demand video (VOD) of one of the broadcaster's past streams.<br/>
    /// * highlight — A highlight reel of one of the broadcaster's past streams. See [Creating Highlights](https://help.twitch.tv/s/article/creating-highlights-and-stream-markers).<br/>
    /// * upload — A video that the broadcaster uploaded to their video library. See Upload under [Video Producer](https://help.twitch.tv/s/article/video-on-demand?language=en%5FUS#videoproducer).
    /// </summary>
    public enum VideoType
    {
        /// <summary>
        /// 
        /// </summary>
        Archive,
        /// <summary>
        /// 
        /// </summary>
        Highlight,
        /// <summary>
        /// 
        /// </summary>
        Upload,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VideoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VideoType? ToEnum(string value)
        {
            return value switch
            {
                "archive" => VideoType.Archive,
                "highlight" => VideoType.Highlight,
                "upload" => VideoType.Upload,
                _ => null,
            };
        }
    }
}