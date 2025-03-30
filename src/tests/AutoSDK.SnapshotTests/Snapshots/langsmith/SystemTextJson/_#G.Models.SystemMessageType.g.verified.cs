//HintName: G.Models.SystemMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: system
    /// </summary>
    public enum SystemMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemMessageType value)
        {
            return value switch
            {
                SystemMessageType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemMessageType? ToEnum(string value)
        {
            return value switch
            {
                "system" => SystemMessageType.System,
                _ => null,
            };
        }
    }
}