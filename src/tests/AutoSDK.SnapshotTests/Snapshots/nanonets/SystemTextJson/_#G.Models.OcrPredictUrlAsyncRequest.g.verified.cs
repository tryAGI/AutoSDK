//HintName: G.Models.OcrPredictUrlAsyncRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrPredictUrlAsyncRequest
    {
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
        /// Initializes a new instance of the <see cref="OcrPredictUrlAsyncRequest" /> class.
        /// </summary>
        /// <param name="urls">
        /// Array of URLs of the training files.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG and/or PDF
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OcrPredictUrlAsyncRequest(
            string urls)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrPredictUrlAsyncRequest" /> class.
        /// </summary>
        public OcrPredictUrlAsyncRequest()
        {
        }
    }
}