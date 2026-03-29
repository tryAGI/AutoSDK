//HintName: G.Models.CreateDocumentOpenAPIAgwJsConv.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateDocumentOpenAPIAgwJsConv
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
    public static class CreateDocumentOpenAPIAgwJsConvExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDocumentOpenAPIAgwJsConv value)
        {
            return value switch
            {
                CreateDocumentOpenAPIAgwJsConv.Str => "str",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDocumentOpenAPIAgwJsConv? ToEnum(string value)
        {
            return value switch
            {
                "str" => CreateDocumentOpenAPIAgwJsConv.Str,
                _ => null,
            };
        }
    }
}