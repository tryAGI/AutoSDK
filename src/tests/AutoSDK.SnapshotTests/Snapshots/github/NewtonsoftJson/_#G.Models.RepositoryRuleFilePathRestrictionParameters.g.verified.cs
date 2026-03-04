//HintName: G.Models.RepositoryRuleFilePathRestrictionParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleFilePathRestrictionParameters
    {
        /// <summary>
        /// The file paths that are restricted from being pushed to the commit graph.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("restricted_file_paths", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RestrictedFilePaths { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleFilePathRestrictionParameters" /> class.
        /// </summary>
        /// <param name="restrictedFilePaths">
        /// The file paths that are restricted from being pushed to the commit graph.
        /// </param>
        public RepositoryRuleFilePathRestrictionParameters(
            global::System.Collections.Generic.IList<string> restrictedFilePaths)
        {
            this.RestrictedFilePaths = restrictedFilePaths ?? throw new global::System.ArgumentNullException(nameof(restrictedFilePaths));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleFilePathRestrictionParameters" /> class.
        /// </summary>
        public RepositoryRuleFilePathRestrictionParameters()
        {
        }
    }
}