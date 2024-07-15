//HintName: G.Models.RepositoryRuleVariant18.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Note: max_file_size is in beta and subject to change.<br/>
    /// Prevent commits that exceed a specified file size limit from being pushed to the commit.
    /// </summary>
    public sealed partial class RepositoryRuleVariant18
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryRuleVariant18Type Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.RepositoryRuleVariant18Parameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}