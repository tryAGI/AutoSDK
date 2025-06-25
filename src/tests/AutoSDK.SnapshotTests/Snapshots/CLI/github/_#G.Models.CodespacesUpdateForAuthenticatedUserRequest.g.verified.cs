//HintName: G.Models.CodespacesUpdateForAuthenticatedUserRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodespacesUpdateForAuthenticatedUserRequest
    {
        /// <summary>
        /// A valid machine to transition this codespace to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("machine")]
        public string? Machine { get; set; }

        /// <summary>
        /// Display name for this codespace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Recently opened folders inside the codespace. It is currently used by the clients to determine the folder path to load the codespace in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recent_folders")]
        public global::System.Collections.Generic.IList<string>? RecentFolders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesUpdateForAuthenticatedUserRequest" /> class.
        /// </summary>
        /// <param name="machine">
        /// A valid machine to transition this codespace to.
        /// </param>
        /// <param name="displayName">
        /// Display name for this codespace
        /// </param>
        /// <param name="recentFolders">
        /// Recently opened folders inside the codespace. It is currently used by the clients to determine the folder path to load the codespace in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodespacesUpdateForAuthenticatedUserRequest(
            string? machine,
            string? displayName,
            global::System.Collections.Generic.IList<string>? recentFolders)
        {
            this.Machine = machine;
            this.DisplayName = displayName;
            this.RecentFolders = recentFolders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesUpdateForAuthenticatedUserRequest" /> class.
        /// </summary>
        public CodespacesUpdateForAuthenticatedUserRequest()
        {
        }
    }
}