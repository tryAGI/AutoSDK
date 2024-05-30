//HintName: G.Models.UpdateChannelGuestStarSettingsBodyGroupLayout.g.cs

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
    public enum UpdateChannelGuestStarSettingsBodyGroupLayout
    {
        /// <summary>
        /// 
        /// </summary>
        TILEDLAYOUT,
        /// <summary>
        /// 
        /// </summary>
        SCREENSHARELAYOUT,
        /// <summary>
        /// 
        /// </summary>
        HORIZONTALLAYOUT,
        /// <summary>
        /// 
        /// </summary>
        VERTICALLAYOUT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateChannelGuestStarSettingsBodyGroupLayoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateChannelGuestStarSettingsBodyGroupLayout value)
        {
            return value switch
            {
                UpdateChannelGuestStarSettingsBodyGroupLayout.TILEDLAYOUT => "TILED_LAYOUT",
                UpdateChannelGuestStarSettingsBodyGroupLayout.SCREENSHARELAYOUT => "SCREENSHARE_LAYOUT",
                UpdateChannelGuestStarSettingsBodyGroupLayout.HORIZONTALLAYOUT => "HORIZONTAL_LAYOUT",
                UpdateChannelGuestStarSettingsBodyGroupLayout.VERTICALLAYOUT => "VERTICAL_LAYOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateChannelGuestStarSettingsBodyGroupLayout ToEnum(string value)
        {
            return value switch
            {
                "TILED_LAYOUT" => UpdateChannelGuestStarSettingsBodyGroupLayout.TILEDLAYOUT,
                "SCREENSHARE_LAYOUT" => UpdateChannelGuestStarSettingsBodyGroupLayout.SCREENSHARELAYOUT,
                "HORIZONTAL_LAYOUT" => UpdateChannelGuestStarSettingsBodyGroupLayout.HORIZONTALLAYOUT,
                "VERTICAL_LAYOUT" => UpdateChannelGuestStarSettingsBodyGroupLayout.VERTICALLAYOUT,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}