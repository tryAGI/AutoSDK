//HintName: G.Models.ReplaceFilterAttributesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReplaceFilterAttributesResponse
    {
        /// <summary>
        /// Job that was created in order to replace filter attributes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string JobId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}