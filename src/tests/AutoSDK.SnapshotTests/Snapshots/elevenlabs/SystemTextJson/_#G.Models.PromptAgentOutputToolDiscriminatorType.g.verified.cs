//HintName: G.Models.PromptAgentOutputToolDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptAgentOutputToolDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Client,
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
                "system" => PromptAgentOutputToolDiscriminatorType.System,
                "webhook" => PromptAgentOutputToolDiscriminatorType.Webhook,
                _ => null,
            };
        }
    }
}