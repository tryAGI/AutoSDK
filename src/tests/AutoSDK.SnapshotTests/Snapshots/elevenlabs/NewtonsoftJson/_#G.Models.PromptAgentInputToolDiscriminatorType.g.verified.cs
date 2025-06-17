//HintName: G.Models.PromptAgentInputToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptAgentInputToolDiscriminatorType
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
    public static class PromptAgentInputToolDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptAgentInputToolDiscriminatorType value)
        {
            return value switch
            {
                PromptAgentInputToolDiscriminatorType.Client => "client",
                PromptAgentInputToolDiscriminatorType.Mcp => "mcp",
                PromptAgentInputToolDiscriminatorType.System => "system",
                PromptAgentInputToolDiscriminatorType.Webhook => "webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptAgentInputToolDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "client" => PromptAgentInputToolDiscriminatorType.Client,
                "mcp" => PromptAgentInputToolDiscriminatorType.Mcp,
                "system" => PromptAgentInputToolDiscriminatorType.System,
                "webhook" => PromptAgentInputToolDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}