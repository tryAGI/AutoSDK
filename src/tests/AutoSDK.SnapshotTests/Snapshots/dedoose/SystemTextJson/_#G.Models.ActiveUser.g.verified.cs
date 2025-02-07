//HintName: G.Models.ActiveUser.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActiveUser
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public global::System.Guid? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accountId")]
        public global::System.Guid? AccountId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstname")]
        public string? Firstname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastname")]
        public string? Lastname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userName")]
        public string? UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionStart")]
        public global::System.DateTime? SessionStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastCheckin")]
        public global::System.DateTime? LastCheckin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeProjectId")]
        public global::System.Guid? ActiveProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activeProjectTitle")]
        public string? ActiveProjectTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connKey")]
        public string? ConnKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveUser" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userId"></param>
        /// <param name="accountId"></param>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="userName"></param>
        /// <param name="sessionStart"></param>
        /// <param name="lastCheckin"></param>
        /// <param name="activeProjectId"></param>
        /// <param name="activeProjectTitle"></param>
        /// <param name="connKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActiveUser(
            global::System.Guid? id,
            global::System.Guid? userId,
            global::System.Guid? accountId,
            string? firstname,
            string? lastname,
            string? userName,
            global::System.DateTime? sessionStart,
            global::System.DateTime? lastCheckin,
            global::System.Guid? activeProjectId,
            string? activeProjectTitle,
            string? connKey)
        {
            this.Id = id;
            this.UserId = userId;
            this.AccountId = accountId;
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.UserName = userName;
            this.SessionStart = sessionStart;
            this.LastCheckin = lastCheckin;
            this.ActiveProjectId = activeProjectId;
            this.ActiveProjectTitle = activeProjectTitle;
            this.ConnKey = connKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActiveUser" /> class.
        /// </summary>
        public ActiveUser()
        {
        }
    }
}