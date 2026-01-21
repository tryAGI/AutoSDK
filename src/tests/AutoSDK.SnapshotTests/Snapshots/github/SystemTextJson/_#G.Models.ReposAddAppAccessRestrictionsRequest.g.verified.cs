//HintName: G.Models.ReposAddAppAccessRestrictionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"apps":["my-app"]}
    /// </summary>
    public sealed partial class ReposAddAppAccessRestrictionsRequest
    {
        /// <summary>
        /// The GitHub Apps that have push access to this branch. Use the slugified version of the app name. **Note**: The list of users, apps, and teams in total is limited to 100 items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("apps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Apps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposAddAppAccessRestrictionsRequest" /> class.
        /// </summary>
        /// <param name="apps">
        /// The GitHub Apps that have push access to this branch. Use the slugified version of the app name. **Note**: The list of users, apps, and teams in total is limited to 100 items.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposAddAppAccessRestrictionsRequest(
            global::System.Collections.Generic.IList<string> apps)
        {
            this.Apps = apps ?? throw new global::System.ArgumentNullException(nameof(apps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposAddAppAccessRestrictionsRequest" /> class.
        /// </summary>
        public ReposAddAppAccessRestrictionsRequest()
        {
        }
    }
}