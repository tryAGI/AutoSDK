﻿//HintName: G.Models.GetVIPsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVIPsResponse
    {
        /// <summary>
        /// The list of VIPs. The list is empty if the broadcaster doesn’t have VIP users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.UserVip> Data { get; set; }

        /// <summary>
        /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::G.GetVIPsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVIPsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of VIPs. The list is empty if the broadcaster doesn’t have VIP users.
        /// </param>
        /// <param name="pagination">
        /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetVIPsResponse(
            global::System.Collections.Generic.IList<global::G.UserVip> data,
            global::G.GetVIPsResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVIPsResponse" /> class.
        /// </summary>
        public GetVIPsResponse()
        {
        }
    }
}