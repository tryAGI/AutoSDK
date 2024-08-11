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
        [global::Newtonsoft.Json.JsonProperty("emails", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Emails { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}