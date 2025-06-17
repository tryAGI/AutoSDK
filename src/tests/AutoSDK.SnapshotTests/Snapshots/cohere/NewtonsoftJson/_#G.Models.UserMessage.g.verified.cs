﻿//HintName: G.Models.UserMessage.g.cs

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
        /// The content of the message. This can be a string or a list of content blocks.<br/>
        /// If a string is provided, it will be treated as a text content block.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.Content2>> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public global::G.UserMessageRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// The content of the message. This can be a string or a list of content blocks.<br/>
        /// If a string is provided, it will be treated as a text content block.
        /// </param>
        /// <param name="role"></param>
        public UserMessage(
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.Content2>> content,
            global::G.UserMessageRole role)
        {
            this.Content = content;
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMessage" /> class.
        /// </summary>
        public UserMessage()
        {
        }
    }
}