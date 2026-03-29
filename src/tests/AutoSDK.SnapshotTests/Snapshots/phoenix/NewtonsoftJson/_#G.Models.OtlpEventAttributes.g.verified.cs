//HintName: G.Models.OtlpEventAttributes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// attributes is a collection of attribute key/value pairs on the event. Attribute keys MUST be unique (it is not allowed to have more than one attribute with the same key).
    /// </summary>
    public sealed partial class OtlpEventAttributes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}