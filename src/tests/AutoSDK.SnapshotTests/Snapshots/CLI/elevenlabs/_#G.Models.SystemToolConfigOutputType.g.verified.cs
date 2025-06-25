//HintName: G.Models.SystemToolConfigOutputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool<br/>
    /// Default Value: system
    /// </summary>
    public enum SystemToolConfigOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        System,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemToolConfigOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemToolConfigOutputType value)
        {
            return value switch
            {
                SystemToolConfigOutputType.System => "system",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemToolConfigOutputType? ToEnum(string value)
        {
            return value switch
            {
                "system" => SystemToolConfigOutputType.System,
                _ => null,
            };
        }
    }
}