//HintName: G.Models.PdfBackend.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Available PDF parsing backends for document processing.<br/>
    /// Different backends offer varying levels of text extraction quality, layout<br/>
    /// preservation, and processing speed. Choose based on your document complexity<br/>
    /// and quality requirements.<br/>
    /// Attributes:<br/>
    ///     PYPDFIUM2: Standard PDF parser using PyPDFium2 library. Fast and<br/>
    ///         reliable for basic text extraction.<br/>
    ///     DOCLING_PARSE: Docling Parse backend providing enhanced layout<br/>
    ///         analysis, structure preservation, and advanced table detection.<br/>
    ///         This is the recommended backend for most use cases.<br/>
    ///     DLPARSE_V1: Deprecated. Maps to `DOCLING_PARSE`.<br/>
    ///     DLPARSE_V2: Deprecated. Maps to `DOCLING_PARSE`.<br/>
    ///     DLPARSE_V4: Deprecated. Maps to `DOCLING_PARSE`.
    /// </summary>
    public enum PdfBackend
    {
        /// <summary>
        /// 
        /// </summary>
        DlparseV1,
        /// <summary>
        /// 
        /// </summary>
        DlparseV2,
        /// <summary>
        /// 
        /// </summary>
        DlparseV4,
        /// <summary>
        /// 
        /// </summary>
        DoclingParse,
        /// <summary>
        /// 
        /// </summary>
        Pypdfium2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PdfBackendExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfBackend value)
        {
            return value switch
            {
                PdfBackend.DlparseV1 => "dlparse_v1",
                PdfBackend.DlparseV2 => "dlparse_v2",
                PdfBackend.DlparseV4 => "dlparse_v4",
                PdfBackend.DoclingParse => "docling_parse",
                PdfBackend.Pypdfium2 => "pypdfium2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfBackend? ToEnum(string value)
        {
            return value switch
            {
                "dlparse_v1" => PdfBackend.DlparseV1,
                "dlparse_v2" => PdfBackend.DlparseV2,
                "dlparse_v4" => PdfBackend.DlparseV4,
                "docling_parse" => PdfBackend.DoclingParse,
                "pypdfium2" => PdfBackend.Pypdfium2,
                _ => null,
            };
        }
    }
}