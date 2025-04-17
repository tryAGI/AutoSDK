//HintName: G.Models.OCRRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OCRRequest
    {
        /// <summary>
        /// Document to run OCR on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.DocumentURLChunk, global::G.ImageURLChunk>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.DocumentURLChunk, global::G.ImageURLChunk> Document { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Max images to extract
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_limit")]
        public int? ImageLimit { get; set; }

        /// <summary>
        /// Minimum height and width of image to extract
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_min_size")]
        public int? ImageMinSize { get; set; }

        /// <summary>
        /// Include image URLs in response
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_image_base64")]
        public bool? IncludeImageBase64 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Model { get; set; }

        /// <summary>
        /// Specific pages user wants to process in various formats: single number, range, or list of both. Starts from 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pages")]
        public global::System.Collections.Generic.IList<int>? Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRRequest" /> class.
        /// </summary>
        /// <param name="document">
        /// Document to run OCR on
        /// </param>
        /// <param name="id"></param>
        /// <param name="imageLimit">
        /// Max images to extract
        /// </param>
        /// <param name="imageMinSize">
        /// Minimum height and width of image to extract
        /// </param>
        /// <param name="includeImageBase64">
        /// Include image URLs in response
        /// </param>
        /// <param name="model"></param>
        /// <param name="pages">
        /// Specific pages user wants to process in various formats: single number, range, or list of both. Starts from 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRRequest(
            global::G.AnyOf<global::G.DocumentURLChunk, global::G.ImageURLChunk> document,
            string? model,
            string? id,
            int? imageLimit,
            int? imageMinSize,
            bool? includeImageBase64,
            global::System.Collections.Generic.IList<int>? pages)
        {
            this.Document = document;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Id = id;
            this.ImageLimit = imageLimit;
            this.ImageMinSize = imageMinSize;
            this.IncludeImageBase64 = includeImageBase64;
            this.Pages = pages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRRequest" /> class.
        /// </summary>
        public OCRRequest()
        {
        }
    }
}