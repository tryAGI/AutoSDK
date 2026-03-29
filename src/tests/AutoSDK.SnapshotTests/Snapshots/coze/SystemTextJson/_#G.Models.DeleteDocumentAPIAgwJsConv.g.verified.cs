//HintName: G.Models.DeleteDocumentAPIAgwJsConv.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeleteDocumentAPIAgwJsConv
    {
        /// <summary>
        /// 
        /// </summary>
        Str,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteDocumentAPIAgwJsConvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteDocumentAPIAgwJsConv value)
        {
            return value switch
            {
                DeleteDocumentAPIAgwJsConv.Str => "str",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteDocumentAPIAgwJsConv? ToEnum(string value)
        {
            return value switch
            {
                "str" => DeleteDocumentAPIAgwJsConv.Str,
                _ => null,
            };
        }
    }
}