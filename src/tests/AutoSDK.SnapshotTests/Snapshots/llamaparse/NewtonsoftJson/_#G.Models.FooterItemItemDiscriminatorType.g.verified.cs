//HintName: G.Models.FooterItemItemDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum FooterItemItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="code")]
        Code,
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