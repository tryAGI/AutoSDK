//HintName: G.Models.ShortBranch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Short Branch
    /// </summary>
    public sealed partial class ShortBranch
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
        public global::G.ShortBranchCommit Commit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protected", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Protected { get; set; } = default!;

        /// <summary>
        /// Branch Protection
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protection")]
        public global::G.BranchProtection? Protection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("protection_url")]
        public string? ProtectionUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortBranch" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="commit"></param>
        /// <param name="protected"></param>
        /// <param name="protection">
        /// Branch Protection
        /// </param>
        /// <param name="protectionUrl"></param>
        public ShortBranch(
            string name,
            global::G.ShortBranchCommit commit,
            bool @protected,
            global::G.BranchProtection? protection,
            string? protectionUrl)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Commit = commit ?? throw new global::System.ArgumentNullException(nameof(commit));
            this.Protected = @protected;
            this.Protection = protection;
            this.ProtectionUrl = protectionUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortBranch" /> class.
        /// </summary>
        public ShortBranch()
        {
        }
    }
}