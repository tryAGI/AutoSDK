//HintName: G.Models.ToolRequestModelToolConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolRequestModelToolConfigDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
        /// <summary>
        /// 
        /// </summary>
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolRequestModelToolConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolRequestModelToolConfigDiscriminatorType value)
        {
            return value switch
            {
                ToolRequestModelToolConfigDiscriminatorType.Client => "client",
                ToolRequestModelToolConfigDiscriminatorType.Mcp => "mcp",
                ToolRequestModelToolConfigDiscriminatorType.System => "system",
                ToolRequestModelToolConfigDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolRequestModelToolConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ToolRequestModelToolConfigDiscriminatorType.Client,
                "mcp" => ToolRequestModelToolConfigDiscriminatorType.Mcp,
                "system" => ToolRequestModelToolConfigDiscriminatorType.System,
                "webhook" => ToolRequestModelToolConfigDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}