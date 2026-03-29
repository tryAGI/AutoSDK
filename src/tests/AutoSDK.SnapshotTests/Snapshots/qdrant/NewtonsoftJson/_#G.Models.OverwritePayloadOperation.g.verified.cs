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
        [global::Newtonsoft.Json.JsonProperty("overwrite_payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SetPayload OverwritePayload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OverwritePayloadOperation" /> class.
        /// </summary>
        /// <param name="overwritePayload">
        /// This data structure is used in API interface and applied across multiple shards
        /// </param>
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