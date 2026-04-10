//HintName: G.Models.GuardMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GuardMessage
    {
        /// <summary>
        /// The role of the message author.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GuardMessageRoleJsonConverter))]
        public global::G.GuardMessageRole Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ContentPart>> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message author.
        /// </param>
        /// <param name="content"></param>
        public GuardMessage(
            global::G.GuardMessageRole role,
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ContentPart>> content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuardMessage" /> class.
        /// </summary>
        public GuardMessage()
        {
        }
    }
}