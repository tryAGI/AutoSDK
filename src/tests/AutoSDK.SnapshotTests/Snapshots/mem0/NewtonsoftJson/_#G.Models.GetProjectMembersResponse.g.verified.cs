//HintName: G.Models.GetProjectMembersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectMembersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("members")]
        public global::System.Collections.Generic.IList<global::G.GetProjectMembersResponseMember>? Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectMembersResponse" /> class.
        /// </summary>
        /// <param name="members"></param>
        public GetProjectMembersResponse(
            global::System.Collections.Generic.IList<global::G.GetProjectMembersResponseMember>? members)
        {
            this.Members = members;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectMembersResponse" /> class.
        /// </summary>
        public GetProjectMembersResponse()
        {
        }
    }
}