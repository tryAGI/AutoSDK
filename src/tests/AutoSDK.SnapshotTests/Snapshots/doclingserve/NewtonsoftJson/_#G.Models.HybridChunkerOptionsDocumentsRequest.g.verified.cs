//HintName: G.Models.HybridChunkerOptionsDocumentsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HybridChunkerOptionsDocumentsRequest
    {
        /// <summary>
        /// Conversion options.<br/>
        /// Default Value: {"from_formats":["docx","pptx","html","image","pdf","asciidoc","md","csv","xlsx","xml_uspto","xml_jats","xml_xbrl","mets_gbs","json_docling","audio","vtt","latex"],"to_formats":["md"],"image_export_mode":"embedded","do_ocr":true,"force_ocr":false,"ocr_engine":"easyocr","pdf_backend":"docling_parse","table_mode":"accurate","table_cell_matching":true,"pipeline":"standard","page_range":[1,9223372036854775807],"document_timeout":604800.0,"abort_on_error":false,"do_table_structure":true,"include_images":true,"images_scale":2.0,"md_page_break_placeholder":"","do_code_enrichment":false,"do_formula_enrichment":false,"do_picture_classification":false,"do_chart_extraction":false,"do_picture_description":false,"picture_description_area_threshold":0.05}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("convert_options")]
        public global::G.ConvertDocumentsRequestOptions? ConvertOptions { get; set; }

        /// <summary>
        /// List of input document sources to process.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sources", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SourcesItem3> Sources { get; set; } = default!;

        /// <summary>
        /// If true, the output will include both the chunks and the converted document.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_converted_doc")]
        public bool? IncludeConvertedDoc { get; set; }

        /// <summary>
        /// Specification for the type of output target.<br/>
        /// Default Value: {"kind":"inbody"}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public global::G.Target3? Target { get; set; }

        /// <summary>
        /// Options specific to the chunker.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunking_options")]
        public global::G.HybridChunkerOptions? ChunkingOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridChunkerOptionsDocumentsRequest" /> class.
        /// </summary>
        /// <param name="sources">
        /// List of input document sources to process.
        /// </param>
        /// <param name="convertOptions">
        /// Conversion options.<br/>
        /// Default Value: {"from_formats":["docx","pptx","html","image","pdf","asciidoc","md","csv","xlsx","xml_uspto","xml_jats","xml_xbrl","mets_gbs","json_docling","audio","vtt","latex"],"to_formats":["md"],"image_export_mode":"embedded","do_ocr":true,"force_ocr":false,"ocr_engine":"easyocr","pdf_backend":"docling_parse","table_mode":"accurate","table_cell_matching":true,"pipeline":"standard","page_range":[1,9223372036854775807],"document_timeout":604800.0,"abort_on_error":false,"do_table_structure":true,"include_images":true,"images_scale":2.0,"md_page_break_placeholder":"","do_code_enrichment":false,"do_formula_enrichment":false,"do_picture_classification":false,"do_chart_extraction":false,"do_picture_description":false,"picture_description_area_threshold":0.05}
        /// </param>
        /// <param name="includeConvertedDoc">
        /// If true, the output will include both the chunks and the converted document.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="target">
        /// Specification for the type of output target.<br/>
        /// Default Value: {"kind":"inbody"}
        /// </param>
        /// <param name="chunkingOptions">
        /// Options specific to the chunker.
        /// </param>
        public HybridChunkerOptionsDocumentsRequest(
            global::System.Collections.Generic.IList<global::G.SourcesItem3> sources,
            global::G.ConvertDocumentsRequestOptions? convertOptions,
            bool? includeConvertedDoc,
            global::G.Target3? target,
            global::G.HybridChunkerOptions? chunkingOptions)
        {
            this.ConvertOptions = convertOptions;
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.IncludeConvertedDoc = includeConvertedDoc;
            this.Target = target;
            this.ChunkingOptions = chunkingOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridChunkerOptionsDocumentsRequest" /> class.
        /// </summary>
        public HybridChunkerOptionsDocumentsRequest()
        {
        }
    }
}