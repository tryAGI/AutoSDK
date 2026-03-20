//HintName: G.Models.SessionInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Session information from the server.
    /// </summary>
    public sealed partial class SessionInfo
    {
        /// <summary>
        /// Session ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Object type (realtime.session).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Model being used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Session voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Session instructions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// Session ID.
        /// </param>
        /// <param name="object">
        /// Object type (realtime.session).
        /// </param>
        /// <param name="model">
        /// Model being used.
        /// </param>
        /// <param name="voice">
        /// Session voice.
        /// </param>
        /// <param name="instructions">
        /// Session instructions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionInfo(
            string? id,
            string? @object,
            string? model,
            string? voice,
            string? instructions)
        {
            this.Id = id;
            this.Object = @object;
            this.Model = model;
            this.Voice = voice;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionInfo" /> class.
        /// </summary>
        public SessionInfo()
        {
        }
    }
}