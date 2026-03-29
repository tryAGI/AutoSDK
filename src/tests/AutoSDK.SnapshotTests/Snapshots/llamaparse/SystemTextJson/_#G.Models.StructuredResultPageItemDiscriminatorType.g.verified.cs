//HintName: G.Models.StructuredResultPageItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum StructuredResultPageItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
        /// <summary>
        /// 
        /// </summary>
        Footer,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Heading,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Link,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        Table,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StructuredResultPageItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StructuredResultPageItemDiscriminatorType value)
        {
            return value switch
            {
                StructuredResultPageItemDiscriminatorType.Code => "code",
                StructuredResultPageItemDiscriminatorType.Footer => "footer",
                StructuredResultPageItemDiscriminatorType.Header => "header",
                StructuredResultPageItemDiscriminatorType.Heading => "heading",
                StructuredResultPageItemDiscriminatorType.Image => "image",
                StructuredResultPageItemDiscriminatorType.Link => "link",
                StructuredResultPageItemDiscriminatorType.List => "list",
                StructuredResultPageItemDiscriminatorType.Table => "table",
                StructuredResultPageItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StructuredResultPageItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code" => StructuredResultPageItemDiscriminatorType.Code,
                "footer" => StructuredResultPageItemDiscriminatorType.Footer,
                "header" => StructuredResultPageItemDiscriminatorType.Header,
                "heading" => StructuredResultPageItemDiscriminatorType.Heading,
                "image" => StructuredResultPageItemDiscriminatorType.Image,
                "link" => StructuredResultPageItemDiscriminatorType.Link,
                "list" => StructuredResultPageItemDiscriminatorType.List,
                "table" => StructuredResultPageItemDiscriminatorType.Table,
                "text" => StructuredResultPageItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}