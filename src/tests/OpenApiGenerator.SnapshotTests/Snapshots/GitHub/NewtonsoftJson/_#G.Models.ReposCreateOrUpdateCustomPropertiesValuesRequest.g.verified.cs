//HintName: G.Models.ReposCreateOrUpdateCustomPropertiesValuesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateOrUpdateCustomPropertiesValuesRequest
    {
        /// <summary>
        /// A list of custom property names and associated values to apply to the repositories.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<CustomPropertyValue> Properties { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}