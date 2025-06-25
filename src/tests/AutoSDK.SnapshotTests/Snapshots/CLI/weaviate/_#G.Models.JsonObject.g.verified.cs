//HintName: G.Models.JsonObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON object value.
    /// </summary>
    public sealed partial class JsonObject
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}