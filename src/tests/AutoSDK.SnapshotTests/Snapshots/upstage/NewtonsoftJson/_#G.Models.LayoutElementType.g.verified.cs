//HintName: G.Models.LayoutElementType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of layout element.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LayoutElementType
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
    public static class LayoutElementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LayoutElementType value)
        {
            return value switch
            {
                LayoutElementType.Caption => "caption",
                LayoutElementType.Chart => "chart",
                LayoutElementType.Equation => "equation",
                LayoutElementType.Figure => "figure",
                LayoutElementType.Footer => "footer",
                LayoutElementType.Header => "header",
                LayoutElementType.Heading => "heading",
                LayoutElementType.List => "list",
                LayoutElementType.Paragraph => "paragraph",
                LayoutElementType.Table => "table",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LayoutElementType? ToEnum(string value)
        {
            return value switch
            {
                "caption" => LayoutElementType.Caption,
                "chart" => LayoutElementType.Chart,
                "equation" => LayoutElementType.Equation,
                "figure" => LayoutElementType.Figure,
                "footer" => LayoutElementType.Footer,
                "header" => LayoutElementType.Header,
                "heading" => LayoutElementType.Heading,
                "list" => LayoutElementType.List,
                "paragraph" => LayoutElementType.Paragraph,
                "table" => LayoutElementType.Table,
                _ => null,
            };
        }
    }
}