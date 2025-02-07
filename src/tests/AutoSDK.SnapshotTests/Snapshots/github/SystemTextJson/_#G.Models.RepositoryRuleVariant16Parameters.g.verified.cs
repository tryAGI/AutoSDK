//HintName: G.Models.RepositoryRuleVariant16Parameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleVariant16Parameters
    {
        /// <summary>
        /// The file paths that are restricted from being pushed to the commit graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restricted_file_paths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RestrictedFilePaths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleVariant16Parameters" /> class.
        /// </summary>
        /// <param name="restrictedFilePaths">
        /// The file paths that are restricted from being pushed to the commit graph.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleVariant16Parameters(
            global::System.Collections.Generic.IList<string> restrictedFilePaths)
        {
            this.RestrictedFilePaths = restrictedFilePaths ?? throw new global::System.ArgumentNullException(nameof(restrictedFilePaths));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleVariant16Parameters" /> class.
        /// </summary>
        public RepositoryRuleVariant16Parameters()
        {
        }
    }
}