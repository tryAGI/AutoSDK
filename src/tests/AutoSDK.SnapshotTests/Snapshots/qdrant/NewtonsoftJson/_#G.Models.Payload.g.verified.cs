//HintName: G.Models.Payload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"city":"London","color":"green"}
    /// </summary>
    public sealed partial class Payload
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}