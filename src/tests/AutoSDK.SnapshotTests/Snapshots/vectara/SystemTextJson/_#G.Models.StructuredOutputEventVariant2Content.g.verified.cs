//HintName: G.Models.StructuredOutputEventVariant2Content.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The structured JSON content conforming to the output schema.<br/>
    /// Example: {"result":"success","data":{"id":123}}
    /// </summary>
    public sealed partial class StructuredOutputEventVariant2Content
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}