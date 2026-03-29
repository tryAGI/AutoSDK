//HintName: G.Models.ModifyMessageApiRequestContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModifyMessageApiRequestContentType
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
    public static class ModifyMessageApiRequestContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModifyMessageApiRequestContentType value)
        {
            return value switch
            {
                ModifyMessageApiRequestContentType.ObjectString => "object_string",
                ModifyMessageApiRequestContentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModifyMessageApiRequestContentType? ToEnum(string value)
        {
            return value switch
            {
                "object_string" => ModifyMessageApiRequestContentType.ObjectString,
                "text" => ModifyMessageApiRequestContentType.Text,
                _ => null,
            };
        }
    }
}