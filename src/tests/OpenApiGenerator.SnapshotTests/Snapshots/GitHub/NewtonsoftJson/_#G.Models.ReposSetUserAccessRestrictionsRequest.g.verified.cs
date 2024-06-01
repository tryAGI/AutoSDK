//HintName: G.Models.ReposSetUserAccessRestrictionsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Example: 
    /// </summary>
    public sealed partial class ReposSetUserAccessRestrictionsRequest
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
    }
}