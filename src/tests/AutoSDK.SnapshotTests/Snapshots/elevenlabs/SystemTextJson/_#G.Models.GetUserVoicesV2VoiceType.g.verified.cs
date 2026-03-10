//HintName: G.Models.GetUserVoicesV2VoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of the voice to filter by. One of 'personal', 'community', 'default', 'workspace', 'non-default', 'saved'. 'non-default' is equal to all but 'default'. 'saved' is equal to non-default, but includes default voices if they have been added to a collection.
    /// </summary>
    public sealed partial class GetUserVoicesV2VoiceType
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}