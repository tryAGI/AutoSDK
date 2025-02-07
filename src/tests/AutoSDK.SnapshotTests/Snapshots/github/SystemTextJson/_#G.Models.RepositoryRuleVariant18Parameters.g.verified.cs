//HintName: G.Models.RepositoryRuleVariant18Parameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleVariant18Parameters
    {
        /// <summary>
        /// The file extensions that are restricted from being pushed to the commit graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restricted_file_extensions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RestrictedFileExtensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleVariant18Parameters" /> class.
        /// </summary>
        /// <param name="restrictedFileExtensions">
        /// The file extensions that are restricted from being pushed to the commit graph.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleVariant18Parameters(
            global::System.Collections.Generic.IList<string> restrictedFileExtensions)
        {
            this.RestrictedFileExtensions = restrictedFileExtensions ?? throw new global::System.ArgumentNullException(nameof(restrictedFileExtensions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleVariant18Parameters" /> class.
        /// </summary>
        public RepositoryRuleVariant18Parameters()
        {
        }
    }
}