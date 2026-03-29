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
        [global::Newtonsoft.Json.JsonProperty("set_payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SetPayload SetPayload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetPayloadOperation" /> class.
        /// </summary>
        /// <param name="setPayload">
        /// This data structure is used in API interface and applied across multiple shards
        /// </param>
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