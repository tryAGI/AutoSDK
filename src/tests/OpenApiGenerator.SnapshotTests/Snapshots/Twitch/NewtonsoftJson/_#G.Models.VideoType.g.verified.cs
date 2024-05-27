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
}