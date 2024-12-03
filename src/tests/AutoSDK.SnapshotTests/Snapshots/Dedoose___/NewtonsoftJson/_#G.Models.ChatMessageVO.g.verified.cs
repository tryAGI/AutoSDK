//HintName: G.Models.ChatMessageVO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatMessageVO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectId")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createStamp")]
        public global::System.DateTime? CreateStamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageVO" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="userId"></param>
        /// <param name="username"></param>
        /// <param name="createStamp"></param>
        /// <param name="message"></param>
        public ChatMessageVO(
            global::System.Guid? id,
            global::System.Guid? projectId,
            global::System.Guid? userId,
            string? username,
            global::System.DateTime? createStamp,
            string? message)
        {
            this.Id = id;
            this.ProjectId = projectId;
            this.UserId = userId;
            this.Username = username;
            this.CreateStamp = createStamp;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatMessageVO" /> class.
        /// </summary>
        public ChatMessageVO()
        {
        }
    }
}