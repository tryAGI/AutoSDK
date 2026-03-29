//HintName: G.Models.ElementType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Types of elements that can be extracted from a document.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ElementType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="figure")]
        Figure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="footer")]
        Footer,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="footnote")]
        Footnote,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="form")]
        Form,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="header")]
        Header,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list-item")]
        ListItem,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="page-number")]
        PageNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="section-header")]
        SectionHeader,
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="title")]
        Title,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElementType value)
        {
            return value switch
            {
                ElementType.Figure => "figure",
                ElementType.Footer => "footer",
                ElementType.Footnote => "footnote",
                ElementType.Form => "form",
                ElementType.Header => "header",
                ElementType.ListItem => "list-item",
                ElementType.PageNumber => "page-number",
                ElementType.SectionHeader => "section-header",
                ElementType.Table => "table",
                ElementType.Text => "text",
                ElementType.Title => "title",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElementType? ToEnum(string value)
        {
            return value switch
            {
                "figure" => ElementType.Figure,
                "footer" => ElementType.Footer,
                "footnote" => ElementType.Footnote,
                "form" => ElementType.Form,
                "header" => ElementType.Header,
                "list-item" => ElementType.ListItem,
                "page-number" => ElementType.PageNumber,
                "section-header" => ElementType.SectionHeader,
                "table" => ElementType.Table,
                "text" => ElementType.Text,
                "title" => ElementType.Title,
                _ => null,
            };
        }
    }
}