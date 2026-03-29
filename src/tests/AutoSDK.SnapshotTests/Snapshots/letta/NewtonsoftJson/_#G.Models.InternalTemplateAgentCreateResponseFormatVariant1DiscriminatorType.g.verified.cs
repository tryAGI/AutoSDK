//HintName: G.Models.InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorType
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
    public static class InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => InternalTemplateAgentCreateResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}