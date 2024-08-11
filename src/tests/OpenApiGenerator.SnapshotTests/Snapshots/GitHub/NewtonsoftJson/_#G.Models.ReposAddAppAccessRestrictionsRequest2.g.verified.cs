//HintName: G.Models.ReposAddAppAccessRestrictionsRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposAddAppAccessRestrictionsRequest2
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
    }
}