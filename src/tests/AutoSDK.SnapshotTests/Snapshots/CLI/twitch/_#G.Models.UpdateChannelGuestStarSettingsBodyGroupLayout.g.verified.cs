//HintName: G.Models.UpdateChannelGuestStarSettingsBodyGroupLayout.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values:   <br/>
    ///   <br/>
    /// * `TILED_LAYOUT`: All live guests are tiled within the browser source with the same size.<br/>
    /// * `SCREENSHARE_LAYOUT`: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.<br/>
    /// * `HORIZONTAL_LAYOUT`: All live guests are arranged in a horizontal bar within the browser source<br/>
    /// * `VERTICAL_LAYOUT`: All live guests are arranged in a vertical bar within the browser source
    /// </summary>
    public enum UpdateChannelGuestStarSettingsBodyGroupLayout
    {
        /// <summary>
        /// All live guests are arranged in a horizontal bar within the browser source
        /// </summary>
        HorizontalLayout,
        /// <summary>
        /// All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.
        /// </summary>
        ScreenshareLayout,
        /// <summary>
        /// All live guests are tiled within the browser source with the same size.
        /// </summary>
        TiledLayout,
        /// <summary>
        /// All live guests are arranged in a vertical bar within the browser source
        /// </summary>
        VerticalLayout,
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
                UpdateChannelGuestStarSettingsBodyGroupLayout.HorizontalLayout => "HORIZONTAL_LAYOUT",
                UpdateChannelGuestStarSettingsBodyGroupLayout.ScreenshareLayout => "SCREENSHARE_LAYOUT",
                UpdateChannelGuestStarSettingsBodyGroupLayout.TiledLayout => "TILED_LAYOUT",
                UpdateChannelGuestStarSettingsBodyGroupLayout.VerticalLayout => "VERTICAL_LAYOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateChannelGuestStarSettingsBodyGroupLayout? ToEnum(string value)
        {
            return value switch
            {
                "HORIZONTAL_LAYOUT" => UpdateChannelGuestStarSettingsBodyGroupLayout.HorizontalLayout,
                "SCREENSHARE_LAYOUT" => UpdateChannelGuestStarSettingsBodyGroupLayout.ScreenshareLayout,
                "TILED_LAYOUT" => UpdateChannelGuestStarSettingsBodyGroupLayout.TiledLayout,
                "VERTICAL_LAYOUT" => UpdateChannelGuestStarSettingsBodyGroupLayout.VerticalLayout,
                _ => null,
            };
        }
    }
}