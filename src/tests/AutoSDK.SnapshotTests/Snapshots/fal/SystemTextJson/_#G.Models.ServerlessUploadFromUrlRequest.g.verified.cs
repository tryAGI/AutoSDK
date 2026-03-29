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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessUploadFromUrlRequest" /> class.
        /// </summary>
        /// <param name="url">
        /// Publicly accessible URL for the file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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