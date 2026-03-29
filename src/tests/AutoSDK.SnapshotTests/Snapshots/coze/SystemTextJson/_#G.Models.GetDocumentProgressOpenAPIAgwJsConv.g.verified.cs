//HintName: G.Models.GetDocumentProgressOpenAPIAgwJsConv.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetDocumentProgressOpenAPIAgwJsConv
    {
        /// <summary>
        /// 
        /// </summary>
        Str,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetDocumentProgressOpenAPIAgwJsConvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentProgressOpenAPIAgwJsConv value)
        {
            return value switch
            {
                GetDocumentProgressOpenAPIAgwJsConv.Str => "str",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentProgressOpenAPIAgwJsConv? ToEnum(string value)
        {
            return value switch
            {
                "str" => GetDocumentProgressOpenAPIAgwJsConv.Str,
                _ => null,
            };
        }
    }
}