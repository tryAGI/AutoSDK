//HintName: G.Models.PromptAgentDBModelToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptAgentDBModelToolDiscriminatorType
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
    public static class PromptAgentDBModelToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAgentDBModelToolDiscriminatorType value)
        {
            return value switch
            {
                PromptAgentDBModelToolDiscriminatorType.Client => "client",
                PromptAgentDBModelToolDiscriminatorType.Mcp => "mcp",
                PromptAgentDBModelToolDiscriminatorType.System => "system",
                PromptAgentDBModelToolDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAgentDBModelToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => PromptAgentDBModelToolDiscriminatorType.Client,
                "mcp" => PromptAgentDBModelToolDiscriminatorType.Mcp,
                "system" => PromptAgentDBModelToolDiscriminatorType.System,
                "webhook" => PromptAgentDBModelToolDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}