//HintName: G.Models.TeamInviteRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamInviteRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamInviteRequest" /> class.
        /// </summary>
        /// <param name="email"></param>
        public TeamInviteRequest(
            string? email)
        {
            this.Email = email;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamInviteRequest" /> class.
        /// </summary>
        public TeamInviteRequest()
        {
        }
    }
}