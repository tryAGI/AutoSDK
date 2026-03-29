//HintName: G.Models.ChecklistResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecklistResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_batch_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxBatchSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_base64_encoding")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool SupportsBase64Encoding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistResponse" /> class.
        /// </summary>
        /// <param name="maxBatchSize"></param>
        /// <param name="supportsBase64Encoding"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChecklistResponse(
            int maxBatchSize,
            bool supportsBase64Encoding)
        {
            this.MaxBatchSize = maxBatchSize;
            this.SupportsBase64Encoding = supportsBase64Encoding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecklistResponse" /> class.
        /// </summary>
        public ChecklistResponse()
        {
        }
    }
}