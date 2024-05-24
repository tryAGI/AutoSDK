//HintName: G.Models.RepositoryRuleDeletion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Only allow users with bypass permissions to delete matching refs.
    /// </summary>
    public sealed partial class RepositoryRuleDeletion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public RepositoryRuleDeletionType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}