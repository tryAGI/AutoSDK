//HintName: G.Models.LlamaParseJobFailureConditions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Conditions that determine when a parsing job should fail vs complete with partial results.<br/>
    /// By default, jobs complete successfully even if some pages fail to parse.<br/>
    /// Use these settings to enforce stricter quality requirements.
    /// </summary>
    public sealed partial class LlamaParseJobFailureConditions
    {
        /// <summary>
        /// Maximum ratio of pages allowed to fail before the job fails (0-1). Example: 0.1 means job fails if more than 10% of pages fail. Default is 0.05 (5%)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_page_failure_ratio")]
        public double? AllowedPageFailureRatio { get; set; }

        /// <summary>
        /// Fail the entire job if any embedded image cannot be extracted. By default, image extraction errors are logged but don't fail the job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_on_image_extraction_error")]
        public bool? FailOnImageExtractionError { get; set; }

        /// <summary>
        /// Fail the entire job if OCR fails on any image. By default, OCR errors result in empty text for that image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_on_image_ocr_error")]
        public bool? FailOnImageOcrError { get; set; }

        /// <summary>
        /// Fail the entire job if markdown cannot be reconstructed for any page. By default, failed pages use fallback text extraction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_on_markdown_reconstruction_error")]
        public bool? FailOnMarkdownReconstructionError { get; set; }

        /// <summary>
        /// Fail the job if a problematic font is detected that may cause incorrect text extraction. Buggy fonts can produce garbled or missing characters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fail_on_buggy_font")]
        public bool? FailOnBuggyFont { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseJobFailureConditions" /> class.
        /// </summary>
        /// <param name="allowedPageFailureRatio">
        /// Maximum ratio of pages allowed to fail before the job fails (0-1). Example: 0.1 means job fails if more than 10% of pages fail. Default is 0.05 (5%)
        /// </param>
        /// <param name="failOnImageExtractionError">
        /// Fail the entire job if any embedded image cannot be extracted. By default, image extraction errors are logged but don't fail the job
        /// </param>
        /// <param name="failOnImageOcrError">
        /// Fail the entire job if OCR fails on any image. By default, OCR errors result in empty text for that image
        /// </param>
        /// <param name="failOnMarkdownReconstructionError">
        /// Fail the entire job if markdown cannot be reconstructed for any page. By default, failed pages use fallback text extraction
        /// </param>
        /// <param name="failOnBuggyFont">
        /// Fail the job if a problematic font is detected that may cause incorrect text extraction. Buggy fonts can produce garbled or missing characters
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParseJobFailureConditions(
            double? allowedPageFailureRatio,
            bool? failOnImageExtractionError,
            bool? failOnImageOcrError,
            bool? failOnMarkdownReconstructionError,
            bool? failOnBuggyFont)
        {
            this.AllowedPageFailureRatio = allowedPageFailureRatio;
            this.FailOnImageExtractionError = failOnImageExtractionError;
            this.FailOnImageOcrError = failOnImageOcrError;
            this.FailOnMarkdownReconstructionError = failOnMarkdownReconstructionError;
            this.FailOnBuggyFont = failOnBuggyFont;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseJobFailureConditions" /> class.
        /// </summary>
        public LlamaParseJobFailureConditions()
        {
        }
    }
}