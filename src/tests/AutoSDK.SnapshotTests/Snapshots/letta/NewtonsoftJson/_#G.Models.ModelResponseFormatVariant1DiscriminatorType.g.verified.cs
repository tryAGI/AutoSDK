//HintName: G.Models.ModelResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelResponseFormatVariant1DiscriminatorType
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
    public static class ModelResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                ModelResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                ModelResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                ModelResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => ModelResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => ModelResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => ModelResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}