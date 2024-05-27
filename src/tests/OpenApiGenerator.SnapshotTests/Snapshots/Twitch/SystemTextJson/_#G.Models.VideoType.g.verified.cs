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
    public abstract class VideoType
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Archive = "archive";
        /// <summary>
        /// 
        /// </summary>
        public const string Highlight = "highlight";
        /// <summary>
        /// 
        /// </summary>
        public const string Upload = "upload";
    }
}