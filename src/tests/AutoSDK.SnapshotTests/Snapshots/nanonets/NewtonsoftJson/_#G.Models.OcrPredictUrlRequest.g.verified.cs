//HintName: G.Models.OcrPredictUrlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OcrPredictUrlRequest
    {
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
        /// Initializes a new instance of the <see cref="OcrPredictUrlRequest" /> class.
        /// </summary>
        /// <param name="urls">
        /// Array of URLs of the training files.<br/>
        /// &lt;br /&gt;<br/>
        /// **Format**: PNG, JPEG and/or PDF
        /// </param>
        public OcrPredictUrlRequest(
            string urls)
        {
            this.Urls = urls ?? throw new global::System.ArgumentNullException(nameof(urls));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OcrPredictUrlRequest" /> class.
        /// </summary>
        public OcrPredictUrlRequest()
        {
        }
    }
}