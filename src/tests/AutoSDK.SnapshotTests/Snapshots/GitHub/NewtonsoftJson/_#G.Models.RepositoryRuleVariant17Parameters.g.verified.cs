//HintName: G.Models.RepositoryRuleVariant17Parameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleVariant17Parameters
    {
        /// <summary>
        /// The maximum amount of characters allowed in file paths
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_file_path_length", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxFilePathLength { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleVariant17Parameters" /> class.
        /// </summary>
        /// <param name="maxFilePathLength">
        /// The maximum amount of characters allowed in file paths
        /// </param>
        public RepositoryRuleVariant17Parameters(
            int maxFilePathLength)
        {
            this.MaxFilePathLength = maxFilePathLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleVariant17Parameters" /> class.
        /// </summary>
        public RepositoryRuleVariant17Parameters()
        {
        }
    }
}