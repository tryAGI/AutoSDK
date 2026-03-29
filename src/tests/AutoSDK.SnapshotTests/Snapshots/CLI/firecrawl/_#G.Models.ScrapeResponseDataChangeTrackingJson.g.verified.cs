//HintName: G.Models.ScrapeResponseDataChangeTrackingJson.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// JSON comparison results when using 'json' mode. Only present when the mode is set to 'json'. This will emit a list of all the keys and their values from the `previous` and `current` scrapes based on the type defined in the `schema`. Example [here](/features/change-tracking)
    /// </summary>
    public sealed partial class ScrapeResponseDataChangeTrackingJson
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}