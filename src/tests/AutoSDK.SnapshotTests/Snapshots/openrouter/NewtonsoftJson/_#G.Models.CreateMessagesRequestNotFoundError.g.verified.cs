//HintName: G.Models.CreateMessagesRequestNotFoundError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMessagesRequestNotFoundError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessagesPostResponsesContentApplicationJsonSchemaType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessagesPostResponsesContentApplicationJsonSchemaError Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessagesRequestNotFoundError" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="type"></param>
        public CreateMessagesRequestNotFoundError(
            global::G.MessagesPostResponsesContentApplicationJsonSchemaError error,
            global::G.MessagesPostResponsesContentApplicationJsonSchemaType type)
        {
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMessagesRequestNotFoundError" /> class.
        /// </summary>
        public CreateMessagesRequestNotFoundError()
        {
        }
    }
}