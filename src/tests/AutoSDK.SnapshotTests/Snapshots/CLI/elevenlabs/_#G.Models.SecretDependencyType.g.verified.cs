//HintName: G.Models.SecretDependencyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretDependencyType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationInitiationWebhook,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretDependencyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretDependencyType value)
        {
            return value switch
            {
                SecretDependencyType.ConversationInitiationWebhook => "conversation_initiation_webhook",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretDependencyType? ToEnum(string value)
        {
            return value switch
            {
                "conversation_initiation_webhook" => SecretDependencyType.ConversationInitiationWebhook,
                _ => null,
            };
        }
    }
}