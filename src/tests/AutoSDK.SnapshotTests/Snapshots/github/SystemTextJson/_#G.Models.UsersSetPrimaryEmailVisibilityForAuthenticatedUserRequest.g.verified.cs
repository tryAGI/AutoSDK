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
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibilityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequestVisibility Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersSetPrimaryEmailVisibilityForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="visibility">
        /// Denotes whether an email is publicly visible.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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