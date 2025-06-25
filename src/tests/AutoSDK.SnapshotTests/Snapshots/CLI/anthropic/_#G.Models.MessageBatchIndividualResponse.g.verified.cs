//HintName: G.Models.MessageBatchIndividualResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is a single line in the response `.jsonl` file and does not represent the response as a whole.
    /// </summary>
    public sealed partial class MessageBatchIndividualResponse
    {
        /// <summary>
        /// Developer-provided ID created for each request in a Message Batch. Useful for matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.<br/>
        /// Example: my-custom-id-1
        /// </summary>
        /// <example>my-custom-id-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CustomId { get; set; }

        /// <summary>
        /// Processing result for this request.<br/>
        /// Contains a Message output if processing was successful, an error response if processing failed, or the reason why processing was not attempted, such as cancellation or expiration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.Result2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Result2 Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatchIndividualResponse" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageBatchIndividualResponse(
            string customId,
            global::G.Result2 result)
        {
            this.CustomId = customId ?? throw new global::System.ArgumentNullException(nameof(customId));
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatchIndividualResponse" /> class.
        /// </summary>
        public MessageBatchIndividualResponse()
        {
        }
    }
}