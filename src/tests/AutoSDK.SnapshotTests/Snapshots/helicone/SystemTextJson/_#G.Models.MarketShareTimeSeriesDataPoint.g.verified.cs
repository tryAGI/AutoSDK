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
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authors")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AuthorTokens> Authors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketShareTimeSeriesDataPoint" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="authors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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