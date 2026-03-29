//HintName: G.Models.PromptVersionDataResponseFormatVariant1DiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptVersionDataResponseFormatVariant1DiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json_schema")]
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionDataResponseFormatVariant1DiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionDataResponseFormatVariant1DiscriminatorType value)
        {
            return value switch
            {
                PromptVersionDataResponseFormatVariant1DiscriminatorType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionDataResponseFormatVariant1DiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => PromptVersionDataResponseFormatVariant1DiscriminatorType.JsonSchema,
                _ => null,
            };
        }
    }
}