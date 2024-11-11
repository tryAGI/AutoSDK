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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ShortBranchCommit Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Protected { get; set; }

        /// <summary>
        /// Branch Protection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection")]
        public global::G.BranchProtection? Protection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protection_url")]
        public string? ProtectionUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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