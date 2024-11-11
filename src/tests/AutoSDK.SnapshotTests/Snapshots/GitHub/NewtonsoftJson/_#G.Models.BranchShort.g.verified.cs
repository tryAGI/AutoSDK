//HintName: G.Models.BranchShort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Branch Short
    /// </summary>
    public sealed partial class BranchShort
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commit", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BranchShortCommit Commit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protected", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Protected { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchShort" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="commit"></param>
        /// <param name="protected"></param>
        public BranchShort(
            string name,
            global::G.BranchShortCommit commit,
            bool @protected)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.Protected = @protected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchShort" /> class.
        /// </summary>
        public BranchShort()
        {
        }
    }
}