//HintName: G.Models.MarketShareTimeSeriesDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarketShareTimeSeriesDataPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public string Time { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("authors", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AuthorTokens> Authors { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketShareTimeSeriesDataPoint" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="authors"></param>
        public MarketShareTimeSeriesDataPoint(
            string time,
            global::System.Collections.Generic.IList<global::G.AuthorTokens> authors)
        {
            this.Time = time ?? throw new global::System.ArgumentNullException(nameof(time));
            this.Authors = authors ?? throw new global::System.ArgumentNullException(nameof(authors));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketShareTimeSeriesDataPoint" /> class.
        /// </summary>
        public MarketShareTimeSeriesDataPoint()
        {
        }
    }
}