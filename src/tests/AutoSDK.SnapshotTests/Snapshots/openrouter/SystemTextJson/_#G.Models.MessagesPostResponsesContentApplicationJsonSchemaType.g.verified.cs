//HintName: G.Models.MessagesPostResponsesContentApplicationJsonSchemaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesPostResponsesContentApplicationJsonSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesPostResponsesContentApplicationJsonSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesPostResponsesContentApplicationJsonSchemaType value)
        {
            return value switch
            {
                MessagesPostResponsesContentApplicationJsonSchemaType.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesPostResponsesContentApplicationJsonSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "error" => MessagesPostResponsesContentApplicationJsonSchemaType.Error,
                _ => null,
            };
        }
    }
}