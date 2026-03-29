//HintName: G.Models.MessagesOutputConfigFormatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesOutputConfigFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        JsonSchema,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesOutputConfigFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesOutputConfigFormatType value)
        {
            return value switch
            {
                MessagesOutputConfigFormatType.JsonSchema => "json_schema",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesOutputConfigFormatType? ToEnum(string value)
        {
            return value switch
            {
                "json_schema" => MessagesOutputConfigFormatType.JsonSchema,
                _ => null,
            };
        }
    }
}