//HintName: G.Models.GetChannelGuestStarSettingsResponseGroupLayout.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values:   <br/>
    ///   <br/>
    /// * `TILED_LAYOUT`: All live guests are tiled within the browser source with the same size.<br/>
    /// * `SCREENSHARE_LAYOUT`: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetChannelGuestStarSettingsResponseGroupLayout
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TILED_LAYOUT")]
        TILEDLAYOUT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="SCREENSHARE_LAYOUT")]
        SCREENSHARELAYOUT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetChannelGuestStarSettingsResponseGroupLayoutExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetChannelGuestStarSettingsResponseGroupLayout value)
        {
            return value switch
            {
                GetChannelGuestStarSettingsResponseGroupLayout.TILEDLAYOUT => "TILED_LAYOUT",
                GetChannelGuestStarSettingsResponseGroupLayout.SCREENSHARELAYOUT => "SCREENSHARE_LAYOUT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetChannelGuestStarSettingsResponseGroupLayout? ToEnum(string value)
        {
            return value switch
            {
                "TILED_LAYOUT" => GetChannelGuestStarSettingsResponseGroupLayout.TILEDLAYOUT,
                "SCREENSHARE_LAYOUT" => GetChannelGuestStarSettingsResponseGroupLayout.SCREENSHARELAYOUT,
                _ => null,
            };
        }
    }
}