//HintName: G.Models.PropertiesConfigRoomMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 房间模式
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PropertiesConfigRoomMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="default")]
        Default,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="podcast")]
        Podcast,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="s2s")]
        S2s,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="translate")]
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