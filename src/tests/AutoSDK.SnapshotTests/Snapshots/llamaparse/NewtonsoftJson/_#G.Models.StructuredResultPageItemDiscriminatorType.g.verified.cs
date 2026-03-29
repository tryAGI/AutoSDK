//HintName: G.Models.StructuredResultPageItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum StructuredResultPageItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code")]
        Code,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="footer")]
        Footer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="header")]
        Header,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="heading")]
        Heading,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="link")]
        Link,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="table")]
        Table,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
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