//HintName: G.Models.ReposAddStatusCheckContextsRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposAddStatusCheckContextsRequest2
    {
        /// <summary>
        /// The name of the status checks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contexts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Contexts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}