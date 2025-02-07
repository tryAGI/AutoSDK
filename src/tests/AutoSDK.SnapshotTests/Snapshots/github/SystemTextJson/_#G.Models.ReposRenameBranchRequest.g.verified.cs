//HintName: G.Models.ReposRenameBranchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposRenameBranchRequest
    {
        /// <summary>
        /// The new name of the branch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposRenameBranchRequest" /> class.
        /// </summary>
        /// <param name="newName">
        /// The new name of the branch.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposRenameBranchRequest(
            string newName)
        {
            this.NewName = newName ?? throw new global::System.ArgumentNullException(nameof(newName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposRenameBranchRequest" /> class.
        /// </summary>
        public ReposRenameBranchRequest()
        {
        }
    }
}