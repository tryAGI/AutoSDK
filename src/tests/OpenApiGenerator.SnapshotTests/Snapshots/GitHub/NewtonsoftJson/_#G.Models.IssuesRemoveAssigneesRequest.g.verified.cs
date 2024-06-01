//HintName: G.Models.IssuesRemoveAssigneesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesRemoveAssigneesRequest
    {
        /// <summary>
        /// Usernames of assignees to remove from an issue. _NOTE: Only users with push access can remove assignees from an issue. Assignees are silently ignored otherwise._
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assignees")]
        public global::System.Collections.Generic.IList<string?>? Assignees { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}