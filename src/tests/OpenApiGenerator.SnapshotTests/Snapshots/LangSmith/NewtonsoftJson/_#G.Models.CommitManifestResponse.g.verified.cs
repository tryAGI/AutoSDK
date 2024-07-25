//HintName: G.Models.CommitManifestResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Response model for get_commit_manifest.
    /// </summary>
    public sealed partial class CommitManifestResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit_hash", Required = global::Newtonsoft.Json.Required.Always)]
        public string CommitHash { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manifest", Required = global::Newtonsoft.Json.Required.Always)]
        public object Manifest { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("examples")]
        public global::System.AnyOf<global::System.Collections.Generic.IList<global::G.RepoExampleResponse>?, object?>? Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}