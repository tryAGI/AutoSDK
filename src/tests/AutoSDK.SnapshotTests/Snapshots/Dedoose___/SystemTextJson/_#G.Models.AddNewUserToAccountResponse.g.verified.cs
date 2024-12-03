//HintName: G.Models.AddNewUserToAccountResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddNewUserToAccountResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.User UserData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userGroupLinkData")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UserGroupLink UserGroupLinkData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNewUserToAccountResponse" /> class.
        /// </summary>
        /// <param name="userData"></param>
        /// <param name="userGroupLinkData"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AddNewUserToAccountResponse(
            global::G.User userData,
            global::G.UserGroupLink userGroupLinkData)
        {
            this.UserData = userData ?? throw new global::System.ArgumentNullException(nameof(userData));
            this.UserGroupLinkData = userGroupLinkData ?? throw new global::System.ArgumentNullException(nameof(userGroupLinkData));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddNewUserToAccountResponse" /> class.
        /// </summary>
        public AddNewUserToAccountResponse()
        {
        }
    }
}