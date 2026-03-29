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
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// List of suggestion values matching the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<object>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRequestSearchSuggestionsResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="values">
        /// List of suggestion values matching the query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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