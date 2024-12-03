//HintName: G.Models.SearchChannelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchChannelsResponse
    {
        /// <summary>
        /// The list of channels that match the query. The list is empty if there are no matches.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.Channel> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchChannelsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of channels that match the query. The list is empty if there are no matches.
        /// </param>
        public SearchChannelsResponse(
            global::System.Collections.Generic.IList<global::G.Channel> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchChannelsResponse" /> class.
        /// </summary>
        public SearchChannelsResponse()
        {
        }
    }
}