//HintName: G.Models.PromptVersionCommitsRequestPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionCommitsRequestPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Commits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionCommitsRequestPublic" /> class.
        /// </summary>
        /// <param name="commits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptVersionCommitsRequestPublic(
            global::System.Collections.Generic.IList<string> commits)
        {
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionCommitsRequestPublic" /> class.
        /// </summary>
        public PromptVersionCommitsRequestPublic()
        {
        }
    }
}