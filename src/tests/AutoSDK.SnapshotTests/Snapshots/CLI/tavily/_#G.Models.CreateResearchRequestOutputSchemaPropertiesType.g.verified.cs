//HintName: G.Models.CreateResearchRequestOutputSchemaPropertiesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the property. Must be one of: object, string, integer, number, or array.
    /// </summary>
    public enum CreateResearchRequestOutputSchemaPropertiesType
    {
        /// <summary>
        /// object, string, integer, number, or array.
        /// </summary>
        Array,
        /// <summary>
        /// object, string, integer, number, or array.
        /// </summary>
        Integer,
        /// <summary>
        /// object, string, integer, number, or array.
        /// </summary>
        Number,
        /// <summary>
        /// object, string, integer, number, or array.
        /// </summary>
        Object,
        /// <summary>
        /// object, string, integer, number, or array.
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateResearchRequestOutputSchemaPropertiesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateResearchRequestOutputSchemaPropertiesType value)
        {
            return value switch
            {
                CreateResearchRequestOutputSchemaPropertiesType.Array => "array",
                CreateResearchRequestOutputSchemaPropertiesType.Integer => "integer",
                CreateResearchRequestOutputSchemaPropertiesType.Number => "number",
                CreateResearchRequestOutputSchemaPropertiesType.Object => "object",
                CreateResearchRequestOutputSchemaPropertiesType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateResearchRequestOutputSchemaPropertiesType? ToEnum(string value)
        {
            return value switch
            {
                "array" => CreateResearchRequestOutputSchemaPropertiesType.Array,
                "integer" => CreateResearchRequestOutputSchemaPropertiesType.Integer,
                "number" => CreateResearchRequestOutputSchemaPropertiesType.Number,
                "object" => CreateResearchRequestOutputSchemaPropertiesType.Object,
                "string" => CreateResearchRequestOutputSchemaPropertiesType.String,
                _ => null,
            };
        }
    }
}