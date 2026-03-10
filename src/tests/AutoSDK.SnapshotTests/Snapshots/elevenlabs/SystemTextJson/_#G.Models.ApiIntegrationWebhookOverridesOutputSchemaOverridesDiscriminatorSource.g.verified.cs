//HintName: G.Models.ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource
    {
        /// <summary>
        /// 
        /// </summary>
        Constant,
        /// <summary>
        /// 
        /// </summary>
        DynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource value)
        {
            return value switch
            {
                ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource.Constant => "constant",
                ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource.DynamicVariable => "dynamic_variable",
                ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "constant" => ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource.Constant,
                "dynamic_variable" => ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource.DynamicVariable,
                "llm" => ApiIntegrationWebhookOverridesOutputSchemaOverridesDiscriminatorSource.Llm,
                _ => null,
            };
        }
    }
}