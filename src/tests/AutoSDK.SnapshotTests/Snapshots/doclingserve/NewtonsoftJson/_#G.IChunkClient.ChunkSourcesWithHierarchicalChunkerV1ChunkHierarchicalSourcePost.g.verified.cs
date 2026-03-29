//HintName: G.IChunkClient.ChunkSourcesWithHierarchicalChunkerV1ChunkHierarchicalSourcePost.g.cs
#nullable enable

namespace G
{
    public partial interface IChunkClient
    {
        /// <summary>
        /// Chunk Sources With Hierarchicalchunker
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChunkDocumentResponse> ChunkSourcesWithHierarchicalChunkerV1ChunkHierarchicalSourcePostAsync(

            global::G.HierarchicalChunkerOptionsDocumentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Chunk Sources With Hierarchicalchunker
        /// </summary>
        /// <param name="convertOptions">
        /// Conversion options.<br/>
        /// Default Value: {"from_formats":["docx","pptx","html","image","pdf","asciidoc","md","csv","xlsx","xml_uspto","xml_jats","xml_xbrl","mets_gbs","json_docling","audio","vtt","latex"],"to_formats":["md"],"image_export_mode":"embedded","do_ocr":true,"force_ocr":false,"ocr_engine":"easyocr","pdf_backend":"docling_parse","table_mode":"accurate","table_cell_matching":true,"pipeline":"standard","page_range":[1,9223372036854775807],"document_timeout":604800.0,"abort_on_error":false,"do_table_structure":true,"include_images":true,"images_scale":2.0,"md_page_break_placeholder":"","do_code_enrichment":false,"do_formula_enrichment":false,"do_picture_classification":false,"do_chart_extraction":false,"do_picture_description":false,"picture_description_area_threshold":0.05}
        /// </param>
        /// <param name="sources">
        /// List of input document sources to process.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChunkDocumentResponse> ChunkSourcesWithHierarchicalChunkerV1ChunkHierarchicalSourcePostAsync(
            global::System.Collections.Generic.IList<global::G.SourcesItem2> sources,
            global::G.ConvertDocumentsRequestOptions? convertOptions = default,
            bool? includeConvertedDoc = default,
            global::G.Target2? target = default,
            global::G.HierarchicalChunkerOptions? chunkingOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}