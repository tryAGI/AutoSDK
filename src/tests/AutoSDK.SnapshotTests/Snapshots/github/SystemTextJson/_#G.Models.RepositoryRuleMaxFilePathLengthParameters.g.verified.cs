//HintName: G.Models.RepositoryRuleMaxFilePathLengthParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleMaxFilePathLengthParameters
    {
        /// <summary>
        /// The maximum amount of characters allowed in file paths
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_file_path_length")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxFilePathLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMaxFilePathLengthParameters" /> class.
        /// </summary>
        /// <param name="maxFilePathLength">
        /// The maximum amount of characters allowed in file paths
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleMaxFilePathLengthParameters(
            int maxFilePathLength)
        {
            this.MaxFilePathLength = maxFilePathLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMaxFilePathLengthParameters" /> class.
        /// </summary>
        public RepositoryRuleMaxFilePathLengthParameters()
        {
        }
    }
}