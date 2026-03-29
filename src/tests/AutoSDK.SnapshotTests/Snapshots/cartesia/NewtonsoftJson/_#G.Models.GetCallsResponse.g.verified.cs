//HintName: G.Models.GetCallsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCallsResponse
    {
        /// <summary>
        /// The list of agent calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentCall> Data { get; set; } = default!;

        /// <summary>
        /// The cursor for the next page of results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCallsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of agent calls.
        /// </param>
        /// <param name="nextPage">
        /// The cursor for the next page of results.
        /// </param>
        public GetCallsResponse(
            global::System.Collections.Generic.IList<global::G.AgentCall> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCallsResponse" /> class.
        /// </summary>
        public GetCallsResponse()
        {
        }
    }
}