//HintName: G.Models.IcUploadUrlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IcUploadUrlRequest
    {
        /// <summary>
        /// The ID of the model on which the operation is to be performed.<br/>
        /// It can be found in the model settings.<br/>
        /// &lt;br /&gt;<br/>
        /// **Eg**: `0a0aa000-0000-0a0-aa00-000a0000000a`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelId { get; set; } = default!;

        /// <summary>
        /// TBD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("category", Required = global::Newtonsoft.Json.Required.Always)]
        public string Category { get; set; } = default!;

        /// <summary>
        /// Array of URLs of the training files.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG and/or PDF
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("urls", Required = global::Newtonsoft.Json.Required.Always)]
        public string Urls { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IcUploadUrlRequest" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model on which the operation is to be performed.<br/>
        /// It can be found in the model settings.<br/>
        /// &lt;br /&gt;<br/>
        /// **Eg**: `0a0aa000-0000-0a0-aa00-000a0000000a`
        /// </param>
        /// <param name="category">
        /// TBD
        /// </param>
        /// <param name="urls">
        /// Array of URLs of the training files.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG and/or PDF
        /// </param>
        public IcUploadUrlRequest(
            string modelId,
            string category,
            string urls)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Category = category ?? throw new global::System.ArgumentNullException(nameof(category));
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IcUploadUrlRequest" /> class.
        /// </summary>
        public IcUploadUrlRequest()
        {
        }
    }
}