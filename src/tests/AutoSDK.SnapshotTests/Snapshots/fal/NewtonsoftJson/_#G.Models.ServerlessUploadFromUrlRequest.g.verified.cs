//HintName: G.Models.ServerlessUploadFromUrlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Upload a file from a URL into the target path
    /// </summary>
    public sealed partial class ServerlessUploadFromUrlRequest
    {
        /// <summary>
        /// Publicly accessible URL for the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessUploadFromUrlRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// Publicly accessible URL for the file
        /// </param>
        public ServerlessUploadFromUrlRequest(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessUploadFromUrlRequest" /> class.
        /// </summary>
        public ServerlessUploadFromUrlRequest()
        {
        }
    }
}