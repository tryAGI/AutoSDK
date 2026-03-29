//HintName: G.Models.CallCreateBatchRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallCreateBatchRes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("res")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AnyOf<global::G.CallStartRes, global::G.CallEndRes>> Res { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallCreateBatchRes" /> class.
        /// </summary>
        /// <param name="res"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallCreateBatchRes(
            global::System.Collections.Generic.IList<global::G.AnyOf<global::G.CallStartRes, global::G.CallEndRes>> res)
        {
            this.Res = res ?? throw new global::System.ArgumentNullException(nameof(res));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallCreateBatchRes" /> class.
        /// </summary>
        public CallCreateBatchRes()
        {
        }
    }
}