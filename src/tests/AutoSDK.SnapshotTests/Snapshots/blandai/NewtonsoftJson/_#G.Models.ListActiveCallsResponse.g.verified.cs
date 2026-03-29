//HintName: G.Models.ListActiveCallsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListActiveCallsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.ActiveCall>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errors")]
        public object? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListActiveCallsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="errors"></param>
        public ListActiveCallsResponse(
            global::System.Collections.Generic.IList<global::G.ActiveCall>? data,
            object? errors)
        {
            this.Data = data;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListActiveCallsResponse" /> class.
        /// </summary>
        public ListActiveCallsResponse()
        {
        }
    }
}