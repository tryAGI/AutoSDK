//HintName: G.Models.PromptAgentOutputToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptAgentOutputToolDiscriminatorType
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
    public static class PromptAgentOutputToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAgentOutputToolDiscriminatorType value)
        {
            return value switch
            {
                PromptAgentOutputToolDiscriminatorType.Client => "client",
                PromptAgentOutputToolDiscriminatorType.Mcp => "mcp",
                PromptAgentOutputToolDiscriminatorType.System => "system",
                PromptAgentOutputToolDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAgentOutputToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => PromptAgentOutputToolDiscriminatorType.Client,
                "mcp" => PromptAgentOutputToolDiscriminatorType.Mcp,
                "system" => PromptAgentOutputToolDiscriminatorType.System,
                "webhook" => PromptAgentOutputToolDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}