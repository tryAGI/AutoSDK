//HintName: G.Models.GetScoresResponseDataBoolean.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetScoresResponseDataBoolean
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace")]
        public global::G.GetScoresResponseTraceData? Trace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataBoolean" /> class.
        /// </summary>
        /// <param name="trace"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetScoresResponseDataBoolean(
            global::G.GetScoresResponseTraceData? trace)
        {
            this.Trace = trace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseDataBoolean" /> class.
        /// </summary>
        public GetScoresResponseDataBoolean()
        {
        }
    }
}