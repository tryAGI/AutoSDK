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
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// An enumeration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RoleType Role { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finishReason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FinishReason FinishReason { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatOutput" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="role">
        /// An enumeration.
        /// </param>
        /// <param name="finishReason"></param>
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