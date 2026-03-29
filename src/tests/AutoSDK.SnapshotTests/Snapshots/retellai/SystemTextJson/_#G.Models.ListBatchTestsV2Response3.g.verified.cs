//HintName: G.Models.ListBatchTestsV2Response3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListBatchTestsV2Response3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ListBatchTestsV2ResponseStatusJsonConverter))]
        public global::G.ListBatchTestsV2ResponseStatus? Status { get; set; }

        /// <summary>
        /// Example: Invalid request format, please check API reference.
        /// </summary>
        /// <example>Invalid request format, please check API reference.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBatchTestsV2Response3" /> class.
        /// </summary>
        /// <param name="status"></param>
        /// <param name="message">
        /// Example: Invalid request format, please check API reference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListBatchTestsV2Response3(
            global::G.ListBatchTestsV2ResponseStatus? status,
            string? message)
        {
            this.Status = status;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBatchTestsV2Response3" /> class.
        /// </summary>
        public ListBatchTestsV2Response3()
        {
        }
    }
}