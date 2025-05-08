//HintName: G.Models.CreateEvalItemVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEvalItemVariant1
    {
        /// <summary>
        /// The role of the message (e.g. "system", "assistant", "user").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// The content of the message.
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
        /// Initializes a new instance of the <see cref="CreateEvalItemVariant1" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message (e.g. "system", "assistant", "user").
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalItemVariant1(
            string role,
            string content)
        {
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalItemVariant1" /> class.
        /// </summary>
        public CreateEvalItemVariant1()
        {
        }
    }
}