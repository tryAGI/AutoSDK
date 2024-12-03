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

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionAnalytics" /> class.
        /// </summary>
        /// <param name="extensionId">
        /// An ID that identifies the extension that the report was generated for.
        /// </param>
        /// <param name="uRL">
        /// The URL that you use to download the report. The URL is valid for 5 minutes.
        /// </param>
        /// <param name="type">
        /// The type of report.
        /// </param>
        /// <param name="dateRange">
        /// The reporting window’s start and end dates, in RFC3339 format.
        /// </param>
        public ExtensionAnalytics(
            string extensionId,
            string uRL,
            string type,
            global::G.ExtensionAnalyticsDateRange dateRange)
        {
            this.ExtensionId = extensionId ?? throw new global::System.ArgumentNullException(nameof(extensionId));
            this.URL = uRL ?? throw new global::System.ArgumentNullException(nameof(uRL));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DateRange = dateRange ?? throw new global::System.ArgumentNullException(nameof(dateRange));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionAnalytics" /> class.
        /// </summary>
        public ExtensionAnalytics()
        {
        }
    }
}