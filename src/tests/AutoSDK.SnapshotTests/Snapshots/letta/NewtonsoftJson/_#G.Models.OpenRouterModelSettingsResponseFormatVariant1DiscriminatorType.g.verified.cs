//HintName: G.Models.OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json_object")]
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json_schema")]
        JsonSchema,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenRouterModelSettingsResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => OpenRouterModelSettingsResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}