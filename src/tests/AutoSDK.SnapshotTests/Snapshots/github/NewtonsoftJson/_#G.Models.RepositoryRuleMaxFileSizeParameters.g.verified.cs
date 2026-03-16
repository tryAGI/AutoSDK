//HintName: G.Models.RepositoryRuleMaxFileSizeParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleMaxFileSizeParameters
    {
        /// <summary>
        /// The maximum file size allowed in megabytes. This limit does not apply to Git Large File Storage (Git LFS).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_file_size", Required = global::Newtonsoft.Json.Required.Always)]
        public long MaxFileSize { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMaxFileSizeParameters" /> class.
        /// </summary>
        /// <param name="maxFileSize">
        /// The maximum file size allowed in megabytes. This limit does not apply to Git Large File Storage (Git LFS).
        /// </param>
        public RepositoryRuleMaxFileSizeParameters(
            long maxFileSize)
        {
            this.MaxFileSize = maxFileSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleMaxFileSizeParameters" /> class.
        /// </summary>
        public RepositoryRuleMaxFileSizeParameters()
        {
        }
    }
}