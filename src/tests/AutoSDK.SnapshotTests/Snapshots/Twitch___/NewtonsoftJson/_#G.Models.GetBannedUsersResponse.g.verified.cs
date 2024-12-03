//HintName: G.Models.GetBannedUsersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetBannedUsersResponse
    {
        /// <summary>
        /// The list of users that were banned or put in a timeout.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BannedUser> Data { get; set; } = default!;

        /// <summary>
        /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination")]
        public global::G.GetBannedUsersResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBannedUsersResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of users that were banned or put in a timeout.
        /// </param>
        /// <param name="pagination">
        /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </param>
        public GetBannedUsersResponse(
            global::System.Collections.Generic.IList<global::G.BannedUser> data,
            global::G.GetBannedUsersResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetBannedUsersResponse" /> class.
        /// </summary>
        public GetBannedUsersResponse()
        {
        }
    }
}