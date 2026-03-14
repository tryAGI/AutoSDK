//HintName: G.Models.SessionArtifactMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom metadata associated with the artifact<br/>
    /// Example: {"original_filename":"report.pdf","source":"user_upload"}
    /// </summary>
    public sealed partial class SessionArtifactMetadata
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}