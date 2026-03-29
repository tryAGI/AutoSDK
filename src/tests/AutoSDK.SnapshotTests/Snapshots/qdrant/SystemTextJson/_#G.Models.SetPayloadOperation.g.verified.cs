//HintName: G.Models.SetPayloadOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetPayloadOperation
    {
        /// <summary>
        /// This data structure is used in API interface and applied across multiple shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("set_payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SetPayload SetPayload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetPayloadOperation" /> class.
        /// </summary>
        /// <param name="setPayload">
        /// This data structure is used in API interface and applied across multiple shards
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetPayloadOperation(
            global::G.SetPayload setPayload)
        {
            this.SetPayload = setPayload ?? throw new global::System.ArgumentNullException(nameof(setPayload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetPayloadOperation" /> class.
        /// </summary>
        public SetPayloadOperation()
        {
        }
    }
}