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
        [global::System.Text.Json.Serialization.JsonPropertyName("since")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Since { get; set; }

        /// <summary>
        /// Example: 2022-12-01 00:00:00+00:00
        /// </summary>
        /// <example>2022-12-01 00:00:00+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("until")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Until { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UsageDetails> Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UsageDetails> Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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