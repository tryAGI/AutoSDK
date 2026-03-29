//HintName: G.Models.FeedbackCreateBatchReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackCreateBatchReq
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FeedbackCreateReq> Batch { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateBatchReq" /> class.
        /// </summary>
        /// <param name="batch"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackCreateBatchReq(
            global::System.Collections.Generic.IList<global::G.FeedbackCreateReq> batch)
        {
            this.Batch = batch ?? throw new global::System.ArgumentNullException(nameof(batch));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateBatchReq" /> class.
        /// </summary>
        public FeedbackCreateBatchReq()
        {
        }
    }
}