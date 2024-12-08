//HintName: G.Models.BetaMessageBatchIndividualResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMessageBatchIndividualResponse
    {
        /// <summary>
        /// Developer-provided ID created for each request in a Message Batch. Useful for matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.<br/>
        /// Example: my-custom-id-1
        /// </summary>
        /// <example>my-custom-id-1</example>
        [global::Newtonsoft.Json.JsonProperty("custom_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string CustomId { get; set; } = default!;

        /// <summary>
        /// Processing result for this request.<br/>
        /// Contains a Message output if processing was successful, an error response if processing failed, or the reason why processing was not attempted, such as cancellation or expiration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BetaMessageBatchResult Result { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageBatchIndividualResponse" /> class.
        /// </summary>
        /// <param name="customId">
        /// Developer-provided ID created for each request in a Message Batch. Useful for matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.<br/>
        /// Example: my-custom-id-1
        /// </param>
        /// <param name="result">
        /// Processing result for this request.<br/>
        /// Contains a Message output if processing was successful, an error response if processing failed, or the reason why processing was not attempted, such as cancellation or expiration.
        /// </param>
        public BetaMessageBatchIndividualResponse(
            string customId,
            global::G.BetaMessageBatchResult result)
        {
            this.CustomId = customId ?? throw new global::System.ArgumentNullException(nameof(customId));
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageBatchIndividualResponse" /> class.
        /// </summary>
        public BetaMessageBatchIndividualResponse()
        {
        }
    }
}