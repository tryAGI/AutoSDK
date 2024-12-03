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
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The blocked user’s login name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserLogin { get; set; }

        /// <summary>
        /// The blocked user’s display name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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