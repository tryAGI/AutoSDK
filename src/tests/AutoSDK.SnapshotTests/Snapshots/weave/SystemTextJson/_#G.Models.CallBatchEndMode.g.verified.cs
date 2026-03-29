//HintName: G.Models.CallBatchEndMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallBatchEndMode
    {
        /// <summary>
        /// Default Value: end
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        public string? Mode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("req")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CallEndReq Req { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallBatchEndMode" /> class.
        /// </summary>
        /// <param name="req"></param>
        /// <param name="mode">
        /// Default Value: end
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallBatchEndMode(
            global::G.CallEndReq req,
            string? mode)
        {
            this.Mode = mode;
            this.Req = req ?? throw new global::System.ArgumentNullException(nameof(req));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallBatchEndMode" /> class.
        /// </summary>
        public CallBatchEndMode()
        {
        }
    }
}