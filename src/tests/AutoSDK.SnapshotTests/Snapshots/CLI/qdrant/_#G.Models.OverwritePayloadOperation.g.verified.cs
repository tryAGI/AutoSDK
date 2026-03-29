//HintName: G.Models.OverwritePayloadOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OverwritePayloadOperation
    {
        /// <summary>
        /// This data structure is used in API interface and applied across multiple shards
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overwrite_payload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SetPayload OverwritePayload { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OverwritePayloadOperation" /> class.
        /// </summary>
        /// <param name="overwritePayload">
        /// This data structure is used in API interface and applied across multiple shards
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OverwritePayloadOperation(
            global::G.SetPayload overwritePayload)
        {
            this.OverwritePayload = overwritePayload ?? throw new global::System.ArgumentNullException(nameof(overwritePayload));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OverwritePayloadOperation" /> class.
        /// </summary>
        public OverwritePayloadOperation()
        {
        }
    }
}