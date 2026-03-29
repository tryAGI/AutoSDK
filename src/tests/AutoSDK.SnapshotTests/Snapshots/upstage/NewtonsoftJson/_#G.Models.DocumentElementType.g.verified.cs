//HintName: G.Models.DocumentElementType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of element (e.g., paragraph, table, figure, heading).
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DocumentElementType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="caption")]
        Caption,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chart")]
        Chart,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="equation")]
        Equation,
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
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="paragraph")]
        Paragraph,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="table")]
        Table,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentElementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentElementType value)
        {
            return value switch
            {
                DocumentElementType.Caption => "caption",
                DocumentElementType.Chart => "chart",
                DocumentElementType.Equation => "equation",
                DocumentElementType.Figure => "figure",
                DocumentElementType.Footer => "footer",
                DocumentElementType.Header => "header",
                DocumentElementType.Heading => "heading",
                DocumentElementType.List => "list",
                DocumentElementType.Paragraph => "paragraph",
                DocumentElementType.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentElementType? ToEnum(string value)
        {
            return value switch
            {
                "caption" => DocumentElementType.Caption,
                "chart" => DocumentElementType.Chart,
                "equation" => DocumentElementType.Equation,
                "figure" => DocumentElementType.Figure,
                "footer" => DocumentElementType.Footer,
                "header" => DocumentElementType.Header,
                "heading" => DocumentElementType.Heading,
                "list" => DocumentElementType.List,
                "paragraph" => DocumentElementType.Paragraph,
                "table" => DocumentElementType.Table,
                _ => null,
            };
        }
    }
}