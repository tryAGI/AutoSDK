//HintName: G.Models.GetRequestSearchSuggestionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetRequestSearchSuggestionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// List of suggestion values matching the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values")]
        public global::System.Collections.Generic.IList<object>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestSearchSuggestionsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="values">
        /// List of suggestion values matching the query.
        /// </param>
        public GetRequestSearchSuggestionsResponse(
            bool? success,
            global::System.Collections.Generic.IList<object>? values)
        {
            this.Success = success;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestSearchSuggestionsResponse" /> class.
        /// </summary>
        public GetRequestSearchSuggestionsResponse()
        {
        }
    }
}