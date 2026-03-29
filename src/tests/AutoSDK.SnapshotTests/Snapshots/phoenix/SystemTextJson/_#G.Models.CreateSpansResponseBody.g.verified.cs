//HintName: G.Models.CreateSpansResponseBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSpansResponseBody
    {
        /// <summary>
        /// Total number of spans received
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_received")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalReceived { get; set; }

        /// <summary>
        /// Number of spans successfully queued for insertion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_queued")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalQueued { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansResponseBody" /> class.
        /// </summary>
        /// <param name="totalReceived">
        /// Total number of spans received
        /// </param>
        /// <param name="totalQueued">
        /// Number of spans successfully queued for insertion
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSpansResponseBody(
            int totalReceived,
            int totalQueued)
        {
            this.TotalReceived = totalReceived;
            this.TotalQueued = totalQueued;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSpansResponseBody" /> class.
        /// </summary>
        public CreateSpansResponseBody()
        {
        }
    }
}