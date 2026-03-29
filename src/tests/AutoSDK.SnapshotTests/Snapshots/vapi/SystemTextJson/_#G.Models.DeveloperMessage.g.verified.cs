//HintName: G.Models.DeveloperMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeveloperMessage
    {
        /// <summary>
        /// This is the role of the message author<br/>
        /// Default Value: developer
        /// </summary>
        /// <default>global::G.DeveloperMessageRole.Developer</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeveloperMessageRoleJsonConverter))]
        public global::G.DeveloperMessageRole Role { get; set; } = global::G.DeveloperMessageRole.Developer;

        /// <summary>
        /// This is the content of the developer message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// This is an optional name for the participant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is an optional metadata for the message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperMessage" /> class.
        /// </summary>
        /// <param name="content">
        /// This is the content of the developer message
        /// </param>
        /// <param name="name">
        /// This is an optional name for the participant
        /// </param>
        /// <param name="metadata">
        /// This is an optional metadata for the message
        /// </param>
        /// <param name="role">
        /// This is the role of the message author<br/>
        /// Default Value: developer
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeveloperMessage(
            string content,
            string? name,
            object? metadata,
            global::G.DeveloperMessageRole role = global::G.DeveloperMessageRole.Developer)
        {
            this.Role = role;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Name = name;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeveloperMessage" /> class.
        /// </summary>
        public DeveloperMessage()
        {
        }
    }
}