//HintName: G.Models.GroupListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("groups")]
        public global::System.Collections.Generic.IList<global::G.GroupDetail>? Groups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupListResponse" /> class.
        /// </summary>
        /// <param name="groups"></param>
        public GroupListResponse(
            global::System.Collections.Generic.IList<global::G.GroupDetail>? groups)
        {
            this.Groups = groups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupListResponse" /> class.
        /// </summary>
        public GroupListResponse()
        {
        }
    }
}