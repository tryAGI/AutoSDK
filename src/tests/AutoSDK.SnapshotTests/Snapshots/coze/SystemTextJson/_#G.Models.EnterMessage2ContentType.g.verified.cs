//HintName: G.Models.EnterMessage2ContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// text, card, object_string
    /// </summary>
    public enum EnterMessage2ContentType
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
    public static class EnterMessage2ContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterMessage2ContentType value)
        {
            return value switch
            {
                EnterMessage2ContentType.ObjectString => "object_string",
                EnterMessage2ContentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterMessage2ContentType? ToEnum(string value)
        {
            return value switch
            {
                "object_string" => EnterMessage2ContentType.ObjectString,
                "text" => EnterMessage2ContentType.Text,
                _ => null,
            };
        }
    }
}