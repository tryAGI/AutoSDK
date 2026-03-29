//HintName: G.Models.GetProjectMembersResponseMember.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetProjectMembersResponseMember
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectMembersResponseMember" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="role"></param>
        public GetProjectMembersResponseMember(
            string? username,
            string? role)
        {
            this.Username = username;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetProjectMembersResponseMember" /> class.
        /// </summary>
        public GetProjectMembersResponseMember()
        {
        }
    }
}