//HintName: G.Models.GetTriggersTypesResponseItemPayload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema of the data payload this trigger will deliver when it fires<br/>
    /// Example: {"message":{"type":"string"},"sender":{"type":"object","properties":{"id":"string","name":"string"}},"timestamp":{"type":"number"}}
    /// </summary>
    public sealed partial class GetTriggersTypesResponseItemPayload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}