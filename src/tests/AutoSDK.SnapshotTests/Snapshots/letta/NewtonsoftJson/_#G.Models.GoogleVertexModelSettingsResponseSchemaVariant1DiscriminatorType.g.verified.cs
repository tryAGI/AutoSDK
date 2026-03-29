//HintName: G.Models.GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType
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
    public static class GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType value)
        {
            return value switch
            {
                GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType.JsonObject => "json_object",
                GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType.JsonSchema => "json_schema",
                GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType.JsonObject,
                "json_schema" => GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType.JsonSchema,
                "text" => GoogleVertexModelSettingsResponseSchemaVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}