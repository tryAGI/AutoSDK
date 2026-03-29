//HintName: G.Models.KPIUserInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for user information (compact format).
    /// </summary>
    public sealed partial class KPIUserInfo
    {
        /// <summary>
        /// User email
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_email", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserEmail { get; set; } = default!;

        /// <summary>
        /// User ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int UserId { get; set; } = default!;

        /// <summary>
        /// Username
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("username", Required = global::Newtonsoft.Json.Required.Always)]
        public string Username { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIUserInfo" /> class.
        /// </summary>
        /// <param name="userEmail">
        /// User email
        /// </param>
        /// <param name="userId">
        /// User ID
        /// </param>
        /// <param name="username">
        /// Username
        /// </param>
        public KPIUserInfo(
            string userEmail,
            int userId,
            string username)
        {
            this.UserEmail = userEmail ?? throw new global::System.ArgumentNullException(nameof(userEmail));
            this.UserId = userId;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIUserInfo" /> class.
        /// </summary>
        public KPIUserInfo()
        {
        }
    }
}