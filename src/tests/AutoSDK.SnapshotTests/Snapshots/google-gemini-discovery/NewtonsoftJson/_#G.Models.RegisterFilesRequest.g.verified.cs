//HintName: G.Models.RegisterFilesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for `RegisterFiles`.
    /// </summary>
    public sealed partial class RegisterFilesRequest
    {
        /// <summary>
        /// Required. The Google Cloud Storage URIs to register. Example: `gs://bucket/object`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uris")]
        public global::System.Collections.Generic.IList<string>? Uris { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterFilesRequest" /> class.
        /// </summary>
        /// <param name="uris">
        /// Required. The Google Cloud Storage URIs to register. Example: `gs://bucket/object`.
        /// </param>
        public RegisterFilesRequest(
            global::System.Collections.Generic.IList<string>? uris)
        {
            this.Uris = uris;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegisterFilesRequest" /> class.
        /// </summary>
        public RegisterFilesRequest()
        {
        }
    }
}