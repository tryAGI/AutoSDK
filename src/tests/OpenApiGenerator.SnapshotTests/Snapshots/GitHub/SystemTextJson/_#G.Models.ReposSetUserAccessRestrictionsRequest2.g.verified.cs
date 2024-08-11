//HintName: G.Models.ReposSetUserAccessRestrictionsRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposSetUserAccessRestrictionsRequest2
    {
        /// <summary>
        /// The username for users
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}