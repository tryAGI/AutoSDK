//HintName: G.Models.ElementType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Types of elements that can be extracted from a document.
    /// </summary>
    public enum ElementType
    {
        /// <summary>
        /// 
        /// </summary>
        Figure,
        /// <summary>
        /// 
        /// </summary>
        Footer,
        /// <summary>
        /// 
        /// </summary>
        Footnote,
        /// <summary>
        /// 
        /// </summary>
        Form,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        ListItem,
        /// <summary>
        /// 
        /// </summary>
        PageNumber,
        /// <summary>
        /// 
        /// </summary>
        SectionHeader,
        /// <summary>
        /// 
        /// </summary>
        Table,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
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