//HintName: G.Models.RelayCommandSay.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelayCommandSay
    {
        /// <summary>
        /// The type of relay command
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RelayCommandSayTypeJsonConverter))]
        public global::G.RelayCommandSayType Type { get; set; }

        /// <summary>
        /// The content for the assistant to speak
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommandSay" /> class.
        /// </summary>
        /// <param name="content">
        /// The content for the assistant to speak
        /// </param>
        /// <param name="type">
        /// The type of relay command
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RelayCommandSay(
            string content,
            global::G.RelayCommandSayType type)
        {
            this.Type = type;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayCommandSay" /> class.
        /// </summary>
        public RelayCommandSay()
        {
        }
    }
}