//HintName: G.Models.ReposRenameBranchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposRenameBranchRequest
    {
        /// <summary>
        /// The new name of the branch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}