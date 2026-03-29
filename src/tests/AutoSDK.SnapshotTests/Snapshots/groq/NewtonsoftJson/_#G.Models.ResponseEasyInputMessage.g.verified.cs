//HintName: G.Models.ResponseEasyInputMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A message input to the model with a role indicating instruction following hierarchy.
    /// </summary>
    public sealed partial class ResponseEasyInputMessage
    {
        /// <summary>
        /// The role of the message input. One of `user`, `assistant`, `system`, or `developer`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ResponseEasyInputMessageRole Role { get; set; } = default!;

        /// <summary>
        /// Text input to the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ResponseInputContent>> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEasyInputMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message input. One of `user`, `assistant`, `system`, or `developer`.
        /// </param>
        /// <param name="content">
        /// Text input to the model.
        /// </param>
        public ResponseEasyInputMessage(
            global::G.ResponseEasyInputMessageRole role,
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ResponseInputContent>> content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseEasyInputMessage" /> class.
        /// </summary>
        public ResponseEasyInputMessage()
        {
        }
    }
}