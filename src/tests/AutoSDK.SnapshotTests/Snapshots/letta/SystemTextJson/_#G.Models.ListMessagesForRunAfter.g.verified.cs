//HintName: G.Models.ListMessagesForRunAfter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Message ID cursor for pagination. Returns messages that come after this message ID in the specified sort order
    /// </summary>
    public sealed partial class ListMessagesForRunAfter
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}