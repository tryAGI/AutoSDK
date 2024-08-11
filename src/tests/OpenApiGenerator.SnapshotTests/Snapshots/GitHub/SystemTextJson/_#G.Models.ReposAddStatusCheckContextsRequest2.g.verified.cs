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
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Contexts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}