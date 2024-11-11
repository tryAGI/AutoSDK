//HintName: G.Models.RepositoryRuleVariant19Parameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleVariant19Parameters
    {
        /// <summary>
        /// The maximum file size allowed in megabytes. This limit does not apply to Git Large File Storage (Git LFS).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_file_size", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxFileSize { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleVariant19Parameters" /> class.
        /// </summary>
        /// <param name="maxFileSize">
        /// The maximum file size allowed in megabytes. This limit does not apply to Git Large File Storage (Git LFS).
        /// </param>
        public RepositoryRuleVariant19Parameters(
            int maxFileSize)
        {
            this.MaxFileSize = maxFileSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleVariant19Parameters" /> class.
        /// </summary>
        public RepositoryRuleVariant19Parameters()
        {
        }
    }
}