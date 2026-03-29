//HintName: G.Models.IcPredictUrlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IcPredictUrlRequest
    {
        /// <summary>
        /// The ID of the model on which the operation is to be performed.<br/>
        /// It can be found in the model settings.<br/>
        /// &lt;br /&gt;<br/>
        /// **Eg**: `0a0aa000-0000-0a0-aa00-000a0000000a`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Array of URLs of the training files.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG and/or PDF
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Urls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IcPredictUrlRequest" /> class.
        /// </summary>
        /// <param name="modelId">
        /// The ID of the model on which the operation is to be performed.<br/>
        /// It can be found in the model settings.<br/>
        /// &lt;br /&gt;<br/>
        /// **Eg**: `0a0aa000-0000-0a0-aa00-000a0000000a`
        /// </param>
        /// <param name="urls">
        /// Array of URLs of the training files.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG and/or PDF
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IcPredictUrlRequest(
            string modelId,
            string urls)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IcPredictUrlRequest" /> class.
        /// </summary>
        public IcPredictUrlRequest()
        {
        }
    }
}