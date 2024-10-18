//HintName: G.Models.ToolContentDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ToolContentDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Document,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ToolContentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ToolContentDiscriminatorType value)
        {
            return value switch
            {
                ToolContentDiscriminatorType.Text => "text",
                ToolContentDiscriminatorType.Document => "document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ToolContentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ToolContentDiscriminatorType.Text,
                "document" => ToolContentDiscriminatorType.Document,
                _ => null,
            };
        }
    }
}