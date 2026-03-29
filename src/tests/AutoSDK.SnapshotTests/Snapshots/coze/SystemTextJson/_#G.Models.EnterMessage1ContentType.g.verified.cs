//HintName: G.Models.EnterMessage1ContentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// text/card/object_string
    /// </summary>
    public enum EnterMessage1ContentType
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
    public static class EnterMessage1ContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnterMessage1ContentType value)
        {
            return value switch
            {
                EnterMessage1ContentType.ObjectString => "object_string",
                EnterMessage1ContentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnterMessage1ContentType? ToEnum(string value)
        {
            return value switch
            {
                "object_string" => EnterMessage1ContentType.ObjectString,
                "text" => EnterMessage1ContentType.Text,
                _ => null,
            };
        }
    }
}