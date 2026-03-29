//HintName: G.Models.GetTriggersTypesBySlugResponseConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration schema required to set up this trigger<br/>
    /// Example: {"channel_id":{"type":"string","required":true},"message_type":{"type":"enum","options":["all","direct","channel"]}}
    /// </summary>
    public sealed partial class GetTriggersTypesBySlugResponseConfig
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}