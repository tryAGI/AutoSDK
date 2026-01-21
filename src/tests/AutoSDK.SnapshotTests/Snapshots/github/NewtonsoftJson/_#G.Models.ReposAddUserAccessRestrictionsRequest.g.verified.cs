//HintName: G.Models.ReposAddUserAccessRestrictionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"users":["mona"]}
    /// </summary>
    public sealed partial class ReposAddUserAccessRestrictionsRequest
    {
        /// <summary>
        /// The username for users
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("users", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Users { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposAddUserAccessRestrictionsRequest" /> class.
        /// </summary>
        /// <param name="users">
        /// The username for users
        /// </param>
        public ReposAddUserAccessRestrictionsRequest(
            global::System.Collections.Generic.IList<string> users)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposAddUserAccessRestrictionsRequest" /> class.
        /// </summary>
        public ReposAddUserAccessRestrictionsRequest()
        {
        }
    }
}