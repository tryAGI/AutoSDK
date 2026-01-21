//HintName: G.Models.BetaMessageBatchIndividualRequestParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMessageBatchIndividualRequestParams
    {
        /// <summary>
        /// Developer-provided ID created for each request in a Message Batch. Useful for matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CustomId { get; set; } = default!;

        /// <summary>
        /// Messages API creation parameters for the individual request. <br/>
        /// See the [Messages API reference](/en/api/messages) for full documentation on available parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("params", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BetaCreateMessageParams Params { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageBatchIndividualRequestParams" /> class.
        /// </summary>
        /// <param name="customId">
        /// Developer-provided ID created for each request in a Message Batch. Useful for matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.
        /// </param>
        /// <param name="params">
        /// Messages API creation parameters for the individual request. <br/>
        /// See the [Messages API reference](/en/api/messages) for full documentation on available parameters.
        /// </param>
        public BetaMessageBatchIndividualRequestParams(
            string customId,
            global::G.BetaCreateMessageParams @params)
        {
            this.CustomId = customId ?? throw new global::System.ArgumentNullException(nameof(customId));
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageBatchIndividualRequestParams" /> class.
        /// </summary>
        public BetaMessageBatchIndividualRequestParams()
        {
        }
    }
}