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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BranchShortCommit Commit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Protected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchShort" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="commit"></param>
        /// <param name="protected"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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