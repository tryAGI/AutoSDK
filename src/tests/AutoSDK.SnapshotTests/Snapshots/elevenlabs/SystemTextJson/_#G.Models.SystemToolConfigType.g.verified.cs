//HintName: G.Models.SystemToolConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool<br/>
    /// Default Value: system
    /// </summary>
    public enum SystemToolConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemToolConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemToolConfigType value)
        {
            return value switch
            {
                SystemToolConfigType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemToolConfigType? ToEnum(string value)
        {
            return value switch
            {
                "system" => SystemToolConfigType.System,
                _ => null,
            };
        }
    }
}