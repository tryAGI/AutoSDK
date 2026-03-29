//HintName: G.Models.FeedbackCreateBatchRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackCreateBatchRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("res")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FeedbackCreateRes> Res { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateBatchRes" /> class.
        /// </summary>
        /// <param name="res"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackCreateBatchRes(
            global::System.Collections.Generic.IList<global::G.FeedbackCreateRes> res)
        {
            this.Res = res ?? throw new global::System.ArgumentNullException(nameof(res));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateBatchRes" /> class.
        /// </summary>
        public FeedbackCreateBatchRes()
        {
        }
    }
}