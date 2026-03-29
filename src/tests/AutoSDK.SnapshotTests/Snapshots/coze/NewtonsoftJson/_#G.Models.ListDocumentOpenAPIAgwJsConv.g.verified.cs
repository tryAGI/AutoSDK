//HintName: G.Models.ListDocumentOpenAPIAgwJsConv.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListDocumentOpenAPIAgwJsConv
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="str")]
        Str,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListDocumentOpenAPIAgwJsConvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListDocumentOpenAPIAgwJsConv value)
        {
            return value switch
            {
                ListDocumentOpenAPIAgwJsConv.Str => "str",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListDocumentOpenAPIAgwJsConv? ToEnum(string value)
        {
            return value switch
            {
                "str" => ListDocumentOpenAPIAgwJsConv.Str,
                _ => null,
            };
        }
    }
}