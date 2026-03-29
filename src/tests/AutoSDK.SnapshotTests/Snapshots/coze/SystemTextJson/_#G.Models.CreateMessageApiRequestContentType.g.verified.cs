//HintName: G.Models.CreateMessageApiRequestContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateMessageApiRequestContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ObjectString,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateMessageApiRequestContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateMessageApiRequestContentType value)
        {
            return value switch
            {
                CreateMessageApiRequestContentType.ObjectString => "object_string",
                CreateMessageApiRequestContentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateMessageApiRequestContentType? ToEnum(string value)
        {
            return value switch
            {
                "object_string" => CreateMessageApiRequestContentType.ObjectString,
                "text" => CreateMessageApiRequestContentType.Text,
                _ => null,
            };
        }
    }
}