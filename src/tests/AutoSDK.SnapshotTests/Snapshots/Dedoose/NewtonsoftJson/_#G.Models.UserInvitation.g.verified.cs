//HintName: G.Models.UserInvitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserInvitation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectIdKey")]
        public string? ProjectIdKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectIDL")]
        public global::System.Guid? ProjectIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invitedByIDL")]
        public global::System.Guid? InvitedByIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userIDL")]
        public global::System.Guid? UserIDL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userEmail")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createStamp")]
        public global::System.DateTime? CreateStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accepted")]
        public bool? Accepted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processed")]
        public bool? Processed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("autoGroupId")]
        public global::System.Guid? AutoGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitation" /> class.
        /// </summary>
        /// <param name="projectIdKey"></param>
        /// <param name="projectId"></param>
        /// <param name="id"></param>
        /// <param name="projectIDL"></param>
        /// <param name="invitedByIDL"></param>
        /// <param name="userIDL"></param>
        /// <param name="userEmail"></param>
        /// <param name="createStamp"></param>
        /// <param name="accepted"></param>
        /// <param name="processed"></param>
        /// <param name="autoGroupId"></param>
        public UserInvitation(
            string? projectIdKey,
            global::System.Guid? projectId,
            global::System.Guid? id,
            global::System.Guid? projectIDL,
            global::System.Guid? invitedByIDL,
            global::System.Guid? userIDL,
            string? userEmail,
            global::System.DateTime? createStamp,
            bool? accepted,
            bool? processed,
            global::System.Guid? autoGroupId)
        {
            this.ProjectIdKey = projectIdKey;
            this.ProjectId = projectId;
            this.Id = id;
            this.ProjectIDL = projectIDL;
            this.InvitedByIDL = invitedByIDL;
            this.UserIDL = userIDL;
            this.UserEmail = userEmail;
            this.CreateStamp = createStamp;
            this.Accepted = accepted;
            this.Processed = processed;
            this.AutoGroupId = autoGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInvitation" /> class.
        /// </summary>
        public UserInvitation()
        {
        }
    }
}