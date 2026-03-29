//HintName: G.Models.ChatFormatJsonSchemaConfigType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatFormatJsonSchemaConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatFormatJsonSchemaConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatFormatJsonSchemaConfigType value)
        {
            return value switch
            {
                ChatFormatJsonSchemaConfigType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatFormatJsonSchemaConfigType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => ChatFormatJsonSchemaConfigType.JsonSchema,
                _ => null,
            };
        }
    }
}