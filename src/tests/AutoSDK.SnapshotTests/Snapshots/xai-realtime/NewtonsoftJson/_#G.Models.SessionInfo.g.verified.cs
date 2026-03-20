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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Object type (realtime.session).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Model being used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Session voice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice")]
        public string? Voice { get; set; }

        /// <summary>
        /// Session instructions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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