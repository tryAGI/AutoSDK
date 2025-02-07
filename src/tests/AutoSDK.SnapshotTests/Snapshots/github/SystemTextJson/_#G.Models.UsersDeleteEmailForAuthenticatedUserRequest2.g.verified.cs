//HintName: G.Models.UsersDeleteEmailForAuthenticatedUserRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deletes one or more email addresses from your GitHub account. Must contain at least one email address. **Note:** Alternatively, you can pass a single email address or an `array` of emails addresses directly, but we recommend that you pass an object using the `emails` key.
    /// </summary>
    public sealed partial class UsersDeleteEmailForAuthenticatedUserRequest2
    {
        /// <summary>
        /// Email addresses associated with the GitHub user account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Emails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersDeleteEmailForAuthenticatedUserRequest2" /> class.
        /// </summary>
        /// <param name="emails">
        /// Email addresses associated with the GitHub user account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsersDeleteEmailForAuthenticatedUserRequest2(
            global::System.Collections.Generic.IList<string> emails)
        {
            this.Emails = emails ?? throw new global::System.ArgumentNullException(nameof(emails));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersDeleteEmailForAuthenticatedUserRequest2" /> class.
        /// </summary>
        public UsersDeleteEmailForAuthenticatedUserRequest2()
        {
        }
    }
}