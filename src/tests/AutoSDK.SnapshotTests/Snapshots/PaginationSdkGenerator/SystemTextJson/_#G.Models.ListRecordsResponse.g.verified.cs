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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.ListRecordsResponseDataItem>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_url")]
        public string? NextUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRecordsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="nextUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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