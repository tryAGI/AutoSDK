//HintName: G.Models.ToolResponseModelToolConfigDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ToolResponseModelToolConfigDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="client")]
        Client,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mcp")]
        Mcp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="system")]
        System,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webhook")]
        Webhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolResponseModelToolConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolResponseModelToolConfigDiscriminatorType value)
        {
            return value switch
            {
                ToolResponseModelToolConfigDiscriminatorType.Client => "client",
                ToolResponseModelToolConfigDiscriminatorType.Mcp => "mcp",
                ToolResponseModelToolConfigDiscriminatorType.System => "system",
                ToolResponseModelToolConfigDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolResponseModelToolConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => ToolResponseModelToolConfigDiscriminatorType.Client,
                "mcp" => ToolResponseModelToolConfigDiscriminatorType.Mcp,
                "system" => ToolResponseModelToolConfigDiscriminatorType.System,
                "webhook" => ToolResponseModelToolConfigDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}