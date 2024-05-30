//HintName: G.Models.ChannelEmoteThemeMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChannelEmoteThemeMode
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

    public static class ChannelEmoteThemeModeExtensions
    {
        public static string ToValueString(this ChannelEmoteThemeMode value)
        {
            return value switch
            {
                ChannelEmoteThemeMode.Dark => "dark",
                ChannelEmoteThemeMode.Light => "light",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChannelEmoteThemeMode ToEnum(string value)
        {
            return value switch
            {
                "dark" => ChannelEmoteThemeMode.Dark,
                "light" => ChannelEmoteThemeMode.Light,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ChannelEmoteThemeMode ToEnum(int value)
        {
            return value switch
            {
                0 => ChannelEmoteThemeMode.Dark,
                1 => ChannelEmoteThemeMode.Light,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}