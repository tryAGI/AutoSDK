//HintName: G.Models.ReplaceFilterAttributesRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplaceFilterAttributesRequest
    {
        /// <summary>
        /// The new filter attributes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter_attributes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FilterAttribute> FilterAttributes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}