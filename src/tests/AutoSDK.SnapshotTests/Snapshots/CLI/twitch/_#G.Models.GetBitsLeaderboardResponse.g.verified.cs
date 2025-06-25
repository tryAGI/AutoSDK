//HintName: G.Models.GetBitsLeaderboardResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBitsLeaderboardResponse
    {
        /// <summary>
        /// A list of leaderboard leaders. The leaders are returned in rank order by how much they’ve cheered. The array is empty if nobody has cheered bits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BitsLeaderboard> Data { get; set; }

        /// <summary>
        /// The reporting window’s start and end dates, in RFC3339 format. The dates are calculated by using the _started\_at_ and _period_ query parameters. If you don’t specify the _started\_at_ query parameter, the fields contain empty strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_range")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetBitsLeaderboardResponseDateRange DateRange { get; set; }

        /// <summary>
        /// The number of ranked users in `data`. This is the value in the _count_ query parameter or the total number of entries on the leaderboard, whichever is less.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBitsLeaderboardResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list of leaderboard leaders. The leaders are returned in rank order by how much they’ve cheered. The array is empty if nobody has cheered bits.
        /// </param>
        /// <param name="dateRange">
        /// The reporting window’s start and end dates, in RFC3339 format. The dates are calculated by using the _started\_at_ and _period_ query parameters. If you don’t specify the _started\_at_ query parameter, the fields contain empty strings.
        /// </param>
        /// <param name="total">
        /// The number of ranked users in `data`. This is the value in the _count_ query parameter or the total number of entries on the leaderboard, whichever is less.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetBitsLeaderboardResponse(
            global::System.Collections.Generic.IList<global::G.BitsLeaderboard> data,
            global::G.GetBitsLeaderboardResponseDateRange dateRange,
            int total)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.DateRange = dateRange ?? throw new global::System.ArgumentNullException(nameof(dateRange));
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBitsLeaderboardResponse" /> class.
        /// </summary>
        public GetBitsLeaderboardResponse()
        {
        }
    }
}