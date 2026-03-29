//HintName: G.Models.CreateMessagesRequestTooManyRequestsError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMessagesRequestTooManyRequestsError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessagesPostResponsesContentApplicationJsonSchemaTypeJsonConverter))]
        public global::G.MessagesPostResponsesContentApplicationJsonSchemaType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MessagesPostResponsesContentApplicationJsonSchemaError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessagesRequestTooManyRequestsError" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateMessagesRequestTooManyRequestsError(
            global::G.MessagesPostResponsesContentApplicationJsonSchemaError error,
            global::G.MessagesPostResponsesContentApplicationJsonSchemaType type)
        {
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessagesRequestTooManyRequestsError" /> class.
        /// </summary>
        public CreateMessagesRequestTooManyRequestsError()
        {
        }
    }
}