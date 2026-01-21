//HintName: G.Models.ReposRemoveAppAccessRestrictionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"apps":["my-app"]}
    /// </summary>
    public sealed partial class ReposRemoveAppAccessRestrictionsRequest
    {
        /// <summary>
        /// The GitHub Apps that have push access to this branch. Use the slugified version of the app name. **Note**: The list of users, apps, and teams in total is limited to 100 items.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apps", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Apps { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposRemoveAppAccessRestrictionsRequest" /> class.
        /// </summary>
        /// <param name="apps">
        /// The GitHub Apps that have push access to this branch. Use the slugified version of the app name. **Note**: The list of users, apps, and teams in total is limited to 100 items.
        /// </param>
        public ReposRemoveAppAccessRestrictionsRequest(
            global::System.Collections.Generic.IList<string> apps)
        {
            this.Apps = apps ?? throw new global::System.ArgumentNullException(nameof(apps));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposRemoveAppAccessRestrictionsRequest" /> class.
        /// </summary>
        public ReposRemoveAppAccessRestrictionsRequest()
        {
        }
    }
}