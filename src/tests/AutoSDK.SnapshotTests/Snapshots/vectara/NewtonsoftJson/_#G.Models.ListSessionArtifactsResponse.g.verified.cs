//HintName: G.Models.ListSessionArtifactsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a paginated list of artifacts in a session
    /// </summary>
    public sealed partial class ListSessionArtifactsResponse
    {
        /// <summary>
        /// List of artifacts in the session
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("artifacts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SessionArtifact> Artifacts { get; set; } = default!;

        /// <summary>
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </summary>
        /// <example>{"page_key":"eyJvZmZzZXQiOjF9"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ListMetadata Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSessionArtifactsResponse" /> class.
        /// </summary>
        /// <param name="artifacts">
        /// List of artifacts in the session
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.<br/>
        /// Example: {"page_key":"eyJvZmZzZXQiOjF9"}
        /// </param>
        public ListSessionArtifactsResponse(
            global::System.Collections.Generic.IList<global::G.SessionArtifact> artifacts,
            global::G.ListMetadata metadata)
        {
            this.Artifacts = artifacts ?? throw new global::System.ArgumentNullException(nameof(artifacts));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSessionArtifactsResponse" /> class.
        /// </summary>
        public ListSessionArtifactsResponse()
        {
        }
    }
}