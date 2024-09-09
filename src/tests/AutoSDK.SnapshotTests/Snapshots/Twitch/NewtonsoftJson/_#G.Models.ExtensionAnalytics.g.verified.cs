//HintName: G.Models.ExtensionAnalytics.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtensionAnalytics
    {
        /// <summary>
        /// An ID that identifies the extension that the report was generated for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extension_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExtensionId { get; set; } = default!;

        /// <summary>
        /// The URL that you use to download the report. The URL is valid for 5 minutes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("URL", Required = global::Newtonsoft.Json.Required.Always)]
        public string URL { get; set; } = default!;

        /// <summary>
        /// The type of report.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// The reporting window’s start and end dates, in RFC3339 format.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date_range", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionAnalyticsDateRange DateRange { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}