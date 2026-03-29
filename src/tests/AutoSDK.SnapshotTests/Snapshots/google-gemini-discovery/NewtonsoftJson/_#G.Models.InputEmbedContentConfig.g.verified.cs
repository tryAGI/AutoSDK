//HintName: G.Models.InputEmbedContentConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configures the input to the batch request.
    /// </summary>
    public sealed partial class InputEmbedContentConfig
    {
        /// <summary>
        /// The name of the `File` containing the input requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// The requests to be processed in the batch if provided as part of the batch creation request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests")]
        public global::G.InlinedEmbedContentRequests? Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputEmbedContentConfig" /> class.
        /// </summary>
        /// <param name="fileName">
        /// The name of the `File` containing the input requests.
        /// </param>
        /// <param name="requests">
        /// The requests to be processed in the batch if provided as part of the batch creation request.
        /// </param>
        public InputEmbedContentConfig(
            string? fileName,
            global::G.InlinedEmbedContentRequests? requests)
        {
            this.FileName = fileName;
            this.Requests = requests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputEmbedContentConfig" /> class.
        /// </summary>
        public InputEmbedContentConfig()
        {
        }
    }
}