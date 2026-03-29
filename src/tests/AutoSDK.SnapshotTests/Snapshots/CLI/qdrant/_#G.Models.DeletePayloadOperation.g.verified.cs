//HintName: G.Models.DeletePayloadOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeletePayloadOperation
    {
        /// <summary>
        /// This data structure is used in API interface and applied across multiple shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DeletePayload DeletePayload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletePayloadOperation" /> class.
        /// </summary>
        /// <param name="deletePayload">
        /// This data structure is used in API interface and applied across multiple shards
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletePayloadOperation(
            global::G.DeletePayload deletePayload)
        {
            this.DeletePayload = deletePayload ?? throw new global::System.ArgumentNullException(nameof(deletePayload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletePayloadOperation" /> class.
        /// </summary>
        public DeletePayloadOperation()
        {
        }
    }
}