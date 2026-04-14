//HintName: G.Models.ListRecordsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListRecordsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.ListRecordsResponseDataItem>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_url")]
        public string? NextUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRecordsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="nextUrl"></param>
        public ListRecordsResponse(
            global::System.Collections.Generic.IList<global::G.ListRecordsResponseDataItem>? data,
            string? nextUrl)
        {
            this.Data = data;
            this.NextUrl = nextUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRecordsResponse" /> class.
        /// </summary>
        public ListRecordsResponse()
        {
        }
    }
}