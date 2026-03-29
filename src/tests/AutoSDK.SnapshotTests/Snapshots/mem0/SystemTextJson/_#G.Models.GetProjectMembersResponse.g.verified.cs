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
        [global::System.Text.Json.Serialization.JsonPropertyName("members")]
        public global::System.Collections.Generic.IList<global::G.GetProjectMembersResponseMember>? Members { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectMembersResponse" /> class.
        /// </summary>
        /// <param name="members"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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