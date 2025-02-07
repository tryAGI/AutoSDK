//HintName: G.Models.ChatOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RoleTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RoleType Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finishReason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FinishReason FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatOutput" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="role">
        /// An enumeration.
        /// </param>
        /// <param name="finishReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatOutput(
            string text,
            global::G.RoleType role,
            global::G.FinishReason finishReason)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Role = role;
            this.FinishReason = finishReason ?? throw new global::System.ArgumentNullException(nameof(finishReason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatOutput" /> class.
        /// </summary>
        public ChatOutput()
        {
        }
    }
}