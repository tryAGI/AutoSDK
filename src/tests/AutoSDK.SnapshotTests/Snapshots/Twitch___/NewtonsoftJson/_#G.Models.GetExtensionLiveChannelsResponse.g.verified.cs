//HintName: G.Models.GetExtensionLiveChannelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetExtensionLiveChannelsResponse
    {
        /// <summary>
        /// The list of broadcasters that are streaming live and that have installed or activated the extension.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExtensionLiveChannel> Data { get; set; } = default!;

        /// <summary>
        /// This field contains the cursor used to page through the results. The field is empty if there are no more pages left to page through. Note that this field is a string compared to other endpoints that use a **Pagination** object. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination")]
        public string? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtensionLiveChannelsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of broadcasters that are streaming live and that have installed or activated the extension.
        /// </param>
        /// <param name="pagination">
        /// This field contains the cursor used to page through the results. The field is empty if there are no more pages left to page through. Note that this field is a string compared to other endpoints that use a **Pagination** object. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </param>
        public GetExtensionLiveChannelsResponse(
            global::System.Collections.Generic.IList<global::G.ExtensionLiveChannel> data,
            string? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetExtensionLiveChannelsResponse" /> class.
        /// </summary>
        public GetExtensionLiveChannelsResponse()
        {
        }
    }
}