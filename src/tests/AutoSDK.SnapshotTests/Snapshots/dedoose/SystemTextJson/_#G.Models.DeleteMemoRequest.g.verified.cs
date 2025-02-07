//HintName: G.Models.DeleteMemoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteMemoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Memo Memo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMemoRequest" /> class.
        /// </summary>
        /// <param name="memo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteMemoRequest(
            global::G.Memo memo)
        {
            this.Memo = memo ?? throw new global::System.ArgumentNullException(nameof(memo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteMemoRequest" /> class.
        /// </summary>
        public DeleteMemoRequest()
        {
        }
    }
}