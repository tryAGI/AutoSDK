//HintName: G.Models.UsageResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageResponse
    {
        /// <summary>
        /// Example: 2021-10-14 00:55:00+00:00
        /// </summary>
        /// <example>2021-10-14 00:55:00+00:00</example>
        [global::Newtonsoft.Json.JsonProperty("since", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Since { get; set; } = default!;

        /// <summary>
        /// Example: 2022-12-01 00:00:00+00:00
        /// </summary>
        /// <example>2022-12-01 00:00:00+00:00</example>
        [global::Newtonsoft.Json.JsonProperty("until", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Until { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UsageDetails> Summary { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.UsageDetails> Details { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResponse" /> class.
        /// </summary>
        /// <param name="since">
        /// Example: 2021-10-14 00:55:00+00:00
        /// </param>
        /// <param name="until">
        /// Example: 2022-12-01 00:00:00+00:00
        /// </param>
        /// <param name="summary"></param>
        /// <param name="details"></param>
        public UsageResponse(
            global::System.DateTime since,
            global::System.DateTime until,
            global::System.Collections.Generic.IList<global::G.UsageDetails> summary,
            global::System.Collections.Generic.IList<global::G.UsageDetails> details)
        {
            this.Since = since;
            this.Until = until;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Details = details ?? throw new global::System.ArgumentNullException(nameof(details));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResponse" /> class.
        /// </summary>
        public UsageResponse()
        {
        }
    }
}