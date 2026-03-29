//HintName: G.Models.ClearPayloadOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClearPayloadOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("clear_payload", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PointsSelector ClearPayload { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearPayloadOperation" /> class.
        /// </summary>
        /// <param name="clearPayload"></param>
        public ClearPayloadOperation(
            global::G.PointsSelector clearPayload)
        {
            this.ClearPayload = clearPayload;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClearPayloadOperation" /> class.
        /// </summary>
        public ClearPayloadOperation()
        {
        }
    }
}