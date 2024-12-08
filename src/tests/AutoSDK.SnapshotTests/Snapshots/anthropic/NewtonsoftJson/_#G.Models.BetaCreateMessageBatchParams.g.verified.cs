//HintName: G.Models.BetaCreateMessageBatchParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCreateMessageBatchParams
    {
        /// <summary>
        /// List of requests for prompt completion. Each is an individual request to create a Message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.BetaMessageBatchIndividualRequestParams> Requests { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateMessageBatchParams" /> class.
        /// </summary>
        /// <param name="requests">
        /// List of requests for prompt completion. Each is an individual request to create a Message.
        /// </param>
        public BetaCreateMessageBatchParams(
            global::System.Collections.Generic.IList<global::G.BetaMessageBatchIndividualRequestParams> requests)
        {
            this.Requests = requests ?? throw new global::System.ArgumentNullException(nameof(requests));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateMessageBatchParams" /> class.
        /// </summary>
        public BetaCreateMessageBatchParams()
        {
        }
    }
}