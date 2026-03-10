//HintName: G.Models.ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="constant")]
        Constant,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dynamic_variable")]
        DynamicVariable,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llm")]
        Llm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSource value)
        {
            return value switch
            {
                ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSource.Constant => "constant",
                ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSource.DynamicVariable => "dynamic_variable",
                ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSource.Llm => "llm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSource? ToEnum(string value)
        {
            return value switch
            {
                "constant" => ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSource.Constant,
                "dynamic_variable" => ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSource.DynamicVariable,
                "llm" => ApiIntegrationWebhookOverridesInputSchemaOverridesDiscriminatorSource.Llm,
                _ => null,
            };
        }
    }
}