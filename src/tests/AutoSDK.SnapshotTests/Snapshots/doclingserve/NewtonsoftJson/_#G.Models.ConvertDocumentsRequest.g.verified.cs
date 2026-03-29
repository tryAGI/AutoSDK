//HintName: G.Models.ConvertDocumentsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertDocumentsRequest
    {
        /// <summary>
        /// Default Value: {"from_formats":["docx","pptx","html","image","pdf","asciidoc","md","csv","xlsx","xml_uspto","xml_jats","xml_xbrl","mets_gbs","json_docling","audio","vtt","latex"],"to_formats":["md"],"image_export_mode":"embedded","do_ocr":true,"force_ocr":false,"ocr_engine":"easyocr","pdf_backend":"docling_parse","table_mode":"accurate","table_cell_matching":true,"pipeline":"standard","page_range":[1,9223372036854775807],"document_timeout":604800.0,"abort_on_error":false,"do_table_structure":true,"include_images":true,"images_scale":2.0,"md_page_break_placeholder":"","do_code_enrichment":false,"do_formula_enrichment":false,"do_picture_classification":false,"do_chart_extraction":false,"do_picture_description":false,"picture_description_area_threshold":0.05}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.ConvertDocumentsRequestOptions? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sources", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SourcesItem> Sources { get; set; } = default!;

        /// <summary>
        /// Default Value: {"kind":"inbody"}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public global::G.Target? Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentsRequest" /> class.
        /// </summary>
        /// <param name="sources"></param>
        /// <param name="options">
        /// Default Value: {"from_formats":["docx","pptx","html","image","pdf","asciidoc","md","csv","xlsx","xml_uspto","xml_jats","xml_xbrl","mets_gbs","json_docling","audio","vtt","latex"],"to_formats":["md"],"image_export_mode":"embedded","do_ocr":true,"force_ocr":false,"ocr_engine":"easyocr","pdf_backend":"docling_parse","table_mode":"accurate","table_cell_matching":true,"pipeline":"standard","page_range":[1,9223372036854775807],"document_timeout":604800.0,"abort_on_error":false,"do_table_structure":true,"include_images":true,"images_scale":2.0,"md_page_break_placeholder":"","do_code_enrichment":false,"do_formula_enrichment":false,"do_picture_classification":false,"do_chart_extraction":false,"do_picture_description":false,"picture_description_area_threshold":0.05}
        /// </param>
        /// <param name="target">
        /// Default Value: {"kind":"inbody"}
        /// </param>
        public ConvertDocumentsRequest(
            global::System.Collections.Generic.IList<global::G.SourcesItem> sources,
            global::G.ConvertDocumentsRequestOptions? options,
            global::G.Target? target)
        {
            this.Options = options;
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentsRequest" /> class.
        /// </summary>
        public ConvertDocumentsRequest()
        {
        }
    }
}