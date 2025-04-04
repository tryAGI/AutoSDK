﻿//HintName: G.Models.ChatCompletionRequestUserMessage.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Messages sent by an end user, containing prompts or additional context<br/>
    /// information.
    /// </summary>
    public sealed partial class ChatCompletionRequestUserMessage
    {
        /// <summary>
        /// The contents of the user message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestUserMessageContentPart>> Content { get; set; } = default!;

        /// <summary>
        /// The role of the messages author, in this case `user`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.ChatCompletionRequestUserMessageRole Role { get; set; }

        /// <summary>
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestUserMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The contents of the user message.
        /// </param>
        /// <param name="role">
        /// The role of the messages author, in this case `user`.
        /// </param>
        /// <param name="name">
        /// An optional name for the participant. Provides the model information to differentiate between participants of the same role.
        /// </param>
        public ChatCompletionRequestUserMessage(
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ChatCompletionRequestUserMessageContentPart>> content,
            global::G.ChatCompletionRequestUserMessageRole role,
            string? name)
        {
            this.Content = content;
            this.Role = role;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestUserMessage" /> class.
        /// </summary>
        public ChatCompletionRequestUserMessage()
        {
        }
    }
}