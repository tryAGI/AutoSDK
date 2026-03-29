//HintName: G.Models.CallQATransferCallAnalysis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallQATransferCallAnalysis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency")]
        public global::System.Collections.Generic.IList<double>? Latency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        public global::System.Collections.Generic.IList<bool>? Successful { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallQATransferCallAnalysis" /> class.
        /// </summary>
        /// <param name="latency"></param>
        /// <param name="successful"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallQATransferCallAnalysis(
            global::System.Collections.Generic.IList<double>? latency,
            global::System.Collections.Generic.IList<bool>? successful)
        {
            this.Latency = latency;
            this.Successful = successful;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallQATransferCallAnalysis" /> class.
        /// </summary>
        public CallQATransferCallAnalysis()
        {
        }
    }
}