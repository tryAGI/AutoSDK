//HintName: G.Models.GetUsageResponseTimeSerie.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Time bucket with grouped usage records
    /// </summary>
    public sealed partial class GetUsageResponseTimeSerie
    {
        /// <summary>
        /// Time bucket timestamp in user's timezone with offset (ISO8601 datetime)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bucket", Required = global::Newtonsoft.Json.Required.Always)]
        public string Bucket { get; set; } = default!;

        /// <summary>
        /// Usage records for this time bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("results", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetUsageResponseTimeSerieResult> Results { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseTimeSerie" /> class.
        /// </summary>
        /// <param name="bucket">
        /// Time bucket timestamp in user's timezone with offset (ISO8601 datetime)
        /// </param>
        /// <param name="results">
        /// Usage records for this time bucket
        /// </param>
        public GetUsageResponseTimeSerie(
            string bucket,
            global::System.Collections.Generic.IList<global::G.GetUsageResponseTimeSerieResult> results)
        {
            this.Bucket = bucket ?? throw new global::System.ArgumentNullException(nameof(bucket));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseTimeSerie" /> class.
        /// </summary>
        public GetUsageResponseTimeSerie()
        {
        }
    }
}