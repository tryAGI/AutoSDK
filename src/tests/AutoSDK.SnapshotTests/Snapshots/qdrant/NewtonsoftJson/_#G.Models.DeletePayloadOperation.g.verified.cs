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
        [global::Newtonsoft.Json.JsonProperty("delete_payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DeletePayload DeletePayload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletePayloadOperation" /> class.
        /// </summary>
        /// <param name="deletePayload">
        /// This data structure is used in API interface and applied across multiple shards
        /// </param>
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