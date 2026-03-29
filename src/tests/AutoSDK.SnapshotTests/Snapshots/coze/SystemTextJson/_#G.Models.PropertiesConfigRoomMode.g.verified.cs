//HintName: G.Models.PropertiesConfigRoomMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 房间模式
    /// </summary>
    public enum PropertiesConfigRoomMode
    {
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Podcast,
        /// <summary>
        /// 
        /// </summary>
        S2s,
        /// <summary>
        /// 
        /// </summary>
        Translate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PropertiesConfigRoomModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PropertiesConfigRoomMode value)
        {
            return value switch
            {
                PropertiesConfigRoomMode.Default => "default",
                PropertiesConfigRoomMode.Podcast => "podcast",
                PropertiesConfigRoomMode.S2s => "s2s",
                PropertiesConfigRoomMode.Translate => "translate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PropertiesConfigRoomMode? ToEnum(string value)
        {
            return value switch
            {
                "default" => PropertiesConfigRoomMode.Default,
                "podcast" => PropertiesConfigRoomMode.Podcast,
                "s2s" => PropertiesConfigRoomMode.S2s,
                "translate" => PropertiesConfigRoomMode.Translate,
                _ => null,
            };
        }
    }
}