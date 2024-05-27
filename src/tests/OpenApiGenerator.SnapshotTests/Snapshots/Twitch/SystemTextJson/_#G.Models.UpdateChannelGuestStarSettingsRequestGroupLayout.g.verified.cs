//HintName: G.Models.UpdateChannelGuestStarSettingsRequestGroupLayout.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values:   
    ///   
    /// * `TILED_LAYOUT`: All live guests are tiled within the browser source with the same size.
    /// * `SCREENSHARE_LAYOUT`: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.
    /// * `HORIZONTAL_LAYOUT`: All live guests are arranged in a horizontal bar within the browser source
    /// * `VERTICAL_LAYOUT`: All live guests are arranged in a vertical bar within the browser source
    /// </summary>
    public abstract class UpdateChannelGuestStarSettingsRequestGroupLayout
    {
        /// <summary>
        /// 
        /// </summary>
        public const string TILEDLAYOUT = "TILED_LAYOUT";
        /// <summary>
        /// 
        /// </summary>
        public const string SCREENSHARELAYOUT = "SCREENSHARE_LAYOUT";
        /// <summary>
        /// 
        /// </summary>
        public const string HORIZONTALLAYOUT = "HORIZONTAL_LAYOUT";
        /// <summary>
        /// 
        /// </summary>
        public const string VERTICALLAYOUT = "VERTICAL_LAYOUT";
    }
}