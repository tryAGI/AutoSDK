//HintName: G.Models.SystemMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A message from the system.
    /// </summary>
    public sealed partial class SystemMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SystemMessageRoleJsonConverter))]
        public global::G.SystemMessageRole Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item2>> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMessage" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="role"></param>
        public SystemMessage(
            global::G.OneOf<string, global::System.Collections.Generic.IList<global::G.ContentVariant2Item2>> content,
            global::G.SystemMessageRole role)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemMessage" /> class.
        /// </summary>
        public SystemMessage()
        {
        }
    }
}