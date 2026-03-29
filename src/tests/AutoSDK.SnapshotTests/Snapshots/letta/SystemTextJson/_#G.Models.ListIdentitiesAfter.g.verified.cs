//HintName: G.Models.ListIdentitiesAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identity ID cursor for pagination. Returns identities that come after this identity ID in the specified sort order
    /// </summary>
    public sealed partial class ListIdentitiesAfter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}