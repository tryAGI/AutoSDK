//HintName: G.Models.GetVoicesV2V2VoicesGetSort.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Which field to sort by, one of 'created_at_unix' or 'name'. 'created_at_unix' may not be available for older voices.
    /// </summary>
    public sealed partial class GetVoicesV2V2VoicesGetSort
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}