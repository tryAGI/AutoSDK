//HintName: G.Models.ChannelEmoteThemeModeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChannelEmoteThemeModeItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dark")]
        Dark,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="light")]
        Light,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChannelEmoteThemeModeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelEmoteThemeModeItem value)
        {
            return value switch
            {
                ChannelEmoteThemeModeItem.Dark => "dark",
                ChannelEmoteThemeModeItem.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelEmoteThemeModeItem? ToEnum(string value)
        {
            return value switch
            {
                "dark" => ChannelEmoteThemeModeItem.Dark,
                "light" => ChannelEmoteThemeModeItem.Light,
                _ => null,
            };
        }
    }
}