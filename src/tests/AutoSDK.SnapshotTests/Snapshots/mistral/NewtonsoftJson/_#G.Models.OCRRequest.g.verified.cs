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
        [global::Newtonsoft.Json.JsonProperty("document", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.DocumentURLChunk, global::G.ImageURLChunk> Document { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Max images to extract
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_limit")]
        public int? ImageLimit { get; set; }

        /// <summary>
        /// Minimum height and width of image to extract
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_min_size")]
        public int? ImageMinSize { get; set; }

        /// <summary>
        /// Include image URLs in response
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_image_base64")]
        public bool? IncludeImageBase64 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Model { get; set; } = default!;

        /// <summary>
        /// Specific pages user wants to process in various formats: single number, range, or list of both. Starts from 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pages")]
        public global::System.Collections.Generic.IList<int>? Pages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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