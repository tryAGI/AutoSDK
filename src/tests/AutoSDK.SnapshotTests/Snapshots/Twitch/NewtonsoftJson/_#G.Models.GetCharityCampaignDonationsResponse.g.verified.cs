//HintName: G.Models.GetCharityCampaignDonationsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCharityCampaignDonationsResponse
    {
        /// <summary>
        /// A list that contains the donations that users have made to the broadcaster’s charity campaign. The list is empty if the broadcaster is not currently running a charity campaign; the donation information is not available after the campaign ends.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CharityCampaignDonation> Data { get; set; } = default!;

        /// <summary>
        /// An object that contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination")]
        public global::G.GetCharityCampaignDonationsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharityCampaignDonationsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the donations that users have made to the broadcaster’s charity campaign. The list is empty if the broadcaster is not currently running a charity campaign; the donation information is not available after the campaign ends.
        /// </param>
        /// <param name="pagination">
        /// An object that contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </param>
        public GetCharityCampaignDonationsResponse(
            global::System.Collections.Generic.IList<global::G.CharityCampaignDonation> data,
            global::G.GetCharityCampaignDonationsResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharityCampaignDonationsResponse" /> class.
        /// </summary>
        public GetCharityCampaignDonationsResponse()
        {
        }
    }
}