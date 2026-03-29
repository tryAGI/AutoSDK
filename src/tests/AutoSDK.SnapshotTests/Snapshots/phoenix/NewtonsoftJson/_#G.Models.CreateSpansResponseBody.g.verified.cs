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
        [global::Newtonsoft.Json.JsonProperty("total_received", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalReceived { get; set; } = default!;

        /// <summary>
        /// Number of spans successfully queued for insertion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_queued", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalQueued { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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