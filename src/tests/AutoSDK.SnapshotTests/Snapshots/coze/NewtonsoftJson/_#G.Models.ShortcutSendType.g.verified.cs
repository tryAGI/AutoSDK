//HintName: G.Models.ShortcutSendType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ShortcutSendType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="panel")]
        Panel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="query")]
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ShortcutSendTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ShortcutSendType value)
        {
            return value switch
            {
                ShortcutSendType.Panel => "panel",
                ShortcutSendType.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ShortcutSendType? ToEnum(string value)
        {
            return value switch
            {
                "panel" => ShortcutSendType.Panel,
                "query" => ShortcutSendType.Query,
                _ => null,
            };
        }
    }
}