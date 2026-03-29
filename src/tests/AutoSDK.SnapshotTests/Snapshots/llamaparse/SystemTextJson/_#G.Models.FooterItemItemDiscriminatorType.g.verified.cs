//HintName: G.Models.FooterItemItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FooterItemItemDiscriminatorType
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
    public static class FooterItemItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FooterItemItemDiscriminatorType value)
        {
            return value switch
            {
                FooterItemItemDiscriminatorType.Code => "code",
                FooterItemItemDiscriminatorType.Heading => "heading",
                FooterItemItemDiscriminatorType.Image => "image",
                FooterItemItemDiscriminatorType.Link => "link",
                FooterItemItemDiscriminatorType.List => "list",
                FooterItemItemDiscriminatorType.Table => "table",
                FooterItemItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FooterItemItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "code" => FooterItemItemDiscriminatorType.Code,
                "heading" => FooterItemItemDiscriminatorType.Heading,
                "image" => FooterItemItemDiscriminatorType.Image,
                "link" => FooterItemItemDiscriminatorType.Link,
                "list" => FooterItemItemDiscriminatorType.List,
                "table" => FooterItemItemDiscriminatorType.Table,
                "text" => FooterItemItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}