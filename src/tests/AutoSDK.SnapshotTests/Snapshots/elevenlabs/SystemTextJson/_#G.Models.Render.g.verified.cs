//HintName: G.Models.Render.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Render
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public global::G.RenderType2? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_ref")]
        public global::G.DubbingMediaReference? MediaRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RenderStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RenderStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Render" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="language"></param>
        /// <param name="type"></param>
        /// <param name="mediaRef"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Render(
            string id,
            int version,
            global::G.RenderStatus status,
            string? language,
            global::G.RenderType2? type,
            global::G.DubbingMediaReference? mediaRef)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.Status = status;
            this.Language = language;
            this.Type = type;
            this.MediaRef = mediaRef;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Render" /> class.
        /// </summary>
        public Render()
        {
        }
    }
}