//HintName: G.Models.GitTree.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The hierarchy between files in a Git repository.
    /// </summary>
    public sealed partial class GitTree
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncated", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Truncated { get; set; } = default!;

        /// <summary>
        /// Objects specifying a tree structure
        /// <br/>Example: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tree", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<GitTreeTree> Tree { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}