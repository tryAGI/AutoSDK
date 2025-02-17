﻿//HintName: G.Models.CommitManifestResponse.g.cs

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
        public global::System.Collections.Generic.IList<global::G.RepoExampleResponse>? Examples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitManifestResponse" /> class.
        /// </summary>
        /// <param name="commitHash"></param>
        /// <param name="manifest"></param>
        /// <param name="examples"></param>
        public CommitManifestResponse(
            string commitHash,
            object manifest,
            global::System.Collections.Generic.IList<global::G.RepoExampleResponse>? examples)
        {
            this.CommitHash = commitHash ?? throw new global::System.ArgumentNullException(nameof(commitHash));
            this.Manifest = manifest ?? throw new global::System.ArgumentNullException(nameof(manifest));
            this.Examples = examples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitManifestResponse" /> class.
        /// </summary>
        public CommitManifestResponse()
        {
        }
    }
}