//HintName: G.Models.HeaderItemItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum HeaderItemItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Code,
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
    public static class HeaderItemItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HeaderItemItemDiscriminatorType value)
        {
            return value switch
            {
                HeaderItemItemDiscriminatorType.Code => "code",
                HeaderItemItemDiscriminatorType.Heading => "heading",
                HeaderItemItemDiscriminatorType.Image => "image",
                HeaderItemItemDiscriminatorType.Link => "link",
                HeaderItemItemDiscriminatorType.List => "list",
                HeaderItemItemDiscriminatorType.Table => "table",
                HeaderItemItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HeaderItemItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code" => HeaderItemItemDiscriminatorType.Code,
                "heading" => HeaderItemItemDiscriminatorType.Heading,
                "image" => HeaderItemItemDiscriminatorType.Image,
                "link" => HeaderItemItemDiscriminatorType.Link,
                "list" => HeaderItemItemDiscriminatorType.List,
                "table" => HeaderItemItemDiscriminatorType.Table,
                "text" => HeaderItemItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}