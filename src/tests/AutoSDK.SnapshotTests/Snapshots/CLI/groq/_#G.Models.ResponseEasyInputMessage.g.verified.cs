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
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseEasyInputMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseEasyInputMessageRole Role { get; set; }

        /// <summary>
        /// Text input to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::G.ResponseInputContent>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ResponseInputContent>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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