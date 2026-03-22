//HintName: G.Models.ReferencedToolCommonModelType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the tool
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ReferencedToolCommonModelType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_integration_webhook")]
        ApiIntegrationWebhook,
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workflow")]
        Workflow,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReferencedToolCommonModelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReferencedToolCommonModelType value)
        {
            return value switch
            {
                ReferencedToolCommonModelType.ApiIntegrationWebhook => "api_integration_webhook",
                ReferencedToolCommonModelType.Client => "client",
                ReferencedToolCommonModelType.Mcp => "mcp",
                ReferencedToolCommonModelType.System => "system",
                ReferencedToolCommonModelType.Webhook => "webhook",
                ReferencedToolCommonModelType.Workflow => "workflow",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReferencedToolCommonModelType? ToEnum(string value)
        {
            return value switch
            {
                "api_integration_webhook" => ReferencedToolCommonModelType.ApiIntegrationWebhook,
                "client" => ReferencedToolCommonModelType.Client,
                "mcp" => ReferencedToolCommonModelType.Mcp,
                "system" => ReferencedToolCommonModelType.System,
                "webhook" => ReferencedToolCommonModelType.Webhook,
                "workflow" => ReferencedToolCommonModelType.Workflow,
                _ => null,
            };
        }
    }
}