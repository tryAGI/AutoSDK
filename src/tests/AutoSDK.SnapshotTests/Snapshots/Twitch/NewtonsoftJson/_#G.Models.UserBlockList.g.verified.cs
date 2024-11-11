//HintName: G.Models.UserBlockList.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserBlockList
    {
        /// <summary>
        /// An ID that identifies the blocked user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The blocked user’s login name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_login", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserLogin { get; set; } = default!;

        /// <summary>
        /// The blocked user’s display name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBlockList" /> class.
        /// </summary>
        /// <param name="userId">
        /// An ID that identifies the blocked user.
        /// </param>
        /// <param name="userLogin">
        /// The blocked user’s login name.
        /// </param>
        /// <param name="displayName">
        /// The blocked user’s display name.
        /// </param>
        public UserBlockList(
            string userId,
            string userLogin,
            string displayName)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.UserLogin = userLogin ?? throw new global::System.ArgumentNullException(nameof(userLogin));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBlockList" /> class.
        /// </summary>
        public UserBlockList()
        {
        }
    }
}