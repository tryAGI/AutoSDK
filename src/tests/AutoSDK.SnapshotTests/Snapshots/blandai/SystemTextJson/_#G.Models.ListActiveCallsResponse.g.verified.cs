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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.ActiveCall>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public object? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListActiveCallsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="errors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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