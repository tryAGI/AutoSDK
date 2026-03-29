//HintName: G.Models.ListPermissionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from `ListPermissions` containing a paginated list of permissions.
    /// </summary>
    public sealed partial class ListPermissionsResponse
    {
        /// <summary>
        /// Returned permissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<global::G.Permission>? Permissions { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPermissionsResponse" /> class.
        /// </summary>
        /// <param name="permissions">
        /// Returned permissions.
        /// </param>
        /// <param name="nextPageToken">
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListPermissionsResponse(
            global::System.Collections.Generic.IList<global::G.Permission>? permissions,
            string? nextPageToken)
        {
            this.Permissions = permissions;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPermissionsResponse" /> class.
        /// </summary>
        public ListPermissionsResponse()
        {
        }
    }
}