//HintName: G.Models.OpenMessageApiContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum OpenMessageApiContentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="object_string")]
        ObjectString,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenMessageApiContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenMessageApiContentType value)
        {
            return value switch
            {
                OpenMessageApiContentType.ObjectString => "object_string",
                OpenMessageApiContentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenMessageApiContentType? ToEnum(string value)
        {
            return value switch
            {
                "object_string" => OpenMessageApiContentType.ObjectString,
                "text" => OpenMessageApiContentType.Text,
                _ => null,
            };
        }
    }
}