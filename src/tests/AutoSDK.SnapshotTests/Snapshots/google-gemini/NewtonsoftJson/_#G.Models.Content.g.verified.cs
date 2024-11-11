//HintName: G.Models.Content.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The base structured datatype containing multi-part content of a message. A `Content` includes a `role` field designating the producer of the `Content` and a `parts` field containing multi-part data that contains the content of the message turn.
    /// </summary>
    public sealed partial class Content
    {
        /// <summary>
        /// Optional. The producer of the content. Must be either 'user' or 'model'. Useful to set for multi-turn conversations, otherwise can be left blank or unset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Ordered `Parts` that constitute a single message. Parts may have different MIME types.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parts")]
        public global::System.Collections.Generic.IList<global::G.Part>? Parts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Content" /> class.
        /// </summary>
        /// <param name="role">
        /// Optional. The producer of the content. Must be either 'user' or 'model'. Useful to set for multi-turn conversations, otherwise can be left blank or unset.
        /// </param>
        /// <param name="parts">
        /// Ordered `Parts` that constitute a single message. Parts may have different MIME types.
        /// </param>
        public Content(
            string? role,
            global::System.Collections.Generic.IList<global::G.Part>? parts)
        {
            this.Role = role;
            this.Parts = parts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Content" /> class.
        /// </summary>
        public Content()
        {
        }
    }
}