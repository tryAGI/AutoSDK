//HintName: G.Models.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest
    {
        /// <summary>
        /// Denotes whether an email is publicly visible.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility Visibility { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="visibility">
        /// Denotes whether an email is publicly visible.
        /// </param>
        public UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest(
            global::G.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility visibility)
        {
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest" /> class.
        /// </summary>
        public UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest()
        {
        }
    }
}