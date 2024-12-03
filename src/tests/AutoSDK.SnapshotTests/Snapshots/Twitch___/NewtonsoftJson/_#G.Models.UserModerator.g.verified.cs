//HintName: G.Models.UserModerator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserModerator
    {
        /// <summary>
        /// The ID of the user that has permission to moderate the broadcaster’s channel.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The user’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// The user’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserModerator" /> class.
        /// </summary>
        /// <param name="userId">
        /// The ID of the user that has permission to moderate the broadcaster’s channel.
        /// </param>
        /// <param name="userLogin">
        /// The user’s login name.
        /// </param>
        /// <param name="userName">
        /// The user’s display name.
        /// </param>
        public UserModerator(
            string userId,
            string userLogin,
            string userName)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.UserName = userName ?? throw new global::System.ArgumentNullException(nameof(userName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserModerator" /> class.
        /// </summary>
        public UserModerator()
        {
        }
    }
}