//HintName: G.Models.CallStartRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallStartRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStartRes" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="traceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallStartRes(
            string id,
            string traceId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallStartRes" /> class.
        /// </summary>
        public CallStartRes()
        {
        }
    }
}