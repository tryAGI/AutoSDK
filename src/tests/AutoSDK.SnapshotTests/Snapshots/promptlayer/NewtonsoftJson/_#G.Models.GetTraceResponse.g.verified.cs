//HintName: G.Models.GetTraceResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTraceResponse
    {
        /// <summary>
        /// Indicates the request was successful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// List of spans belonging to this trace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("spans")]
        public global::System.Collections.Generic.IList<global::G.GetTraceResponseSpan>? Spans { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTraceResponse" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates the request was successful.
        /// </param>
        /// <param name="spans">
        /// List of spans belonging to this trace.
        /// </param>
        public GetTraceResponse(
            bool? success,
            global::System.Collections.Generic.IList<global::G.GetTraceResponseSpan>? spans)
        {
            this.Success = success;
            this.Spans = spans;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTraceResponse" /> class.
        /// </summary>
        public GetTraceResponse()
        {
        }
    }
}