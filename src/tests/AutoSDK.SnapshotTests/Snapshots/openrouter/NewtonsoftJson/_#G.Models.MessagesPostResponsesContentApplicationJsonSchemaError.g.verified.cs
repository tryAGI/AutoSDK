//HintName: G.Models.MessagesPostResponsesContentApplicationJsonSchemaError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesPostResponsesContentApplicationJsonSchemaError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesPostResponsesContentApplicationJsonSchemaError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public MessagesPostResponsesContentApplicationJsonSchemaError(
            string type,
            string message)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesPostResponsesContentApplicationJsonSchemaError" /> class.
        /// </summary>
        public MessagesPostResponsesContentApplicationJsonSchemaError()
        {
        }
    }
}