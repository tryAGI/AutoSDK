//HintName: G.Models.UpdateAgentResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateAgentResponseFormatVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonObject,
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAgentResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAgentResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                UpdateAgentResponseFormatVariant1DiscriminatorType.JsonObject => "json_object",
                UpdateAgentResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                UpdateAgentResponseFormatVariant1DiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAgentResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_object" => UpdateAgentResponseFormatVariant1DiscriminatorType.JsonObject,
                "json_schema" => UpdateAgentResponseFormatVariant1DiscriminatorType.JsonSchema,
                "text" => UpdateAgentResponseFormatVariant1DiscriminatorType.Text,
                _ => null,
            };
        }
    }
}