//HintName: G.Models.UserMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A message from the user.
    /// </summary>
    public sealed partial class UserMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.UserMessageRoleJsonConverter))]
        public global::G.UserMessageRole Role { get; set; }

        /// <summary>
        /// The content of the message. This can be a string or a list of content blocks.<br/>
        /// If a string is provided, it will be treated as a text content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.Content>> Content { get; set; }

        /// <summary>
        /// Documents seen by the model when generating the reply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::G.ChatDocument>? Documents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}