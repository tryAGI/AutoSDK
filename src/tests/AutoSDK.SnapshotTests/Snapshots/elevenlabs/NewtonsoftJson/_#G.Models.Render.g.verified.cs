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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public string? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RenderType2? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_ref")]
        public global::G.DubbingMediaReference? MediaRef { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RenderStatusJsonConverter))]
        public global::G.RenderStatus Status { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Render" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="status"></param>
        /// <param name="language"></param>
        /// <param name="type"></param>
        /// <param name="mediaRef"></param>
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
            this.Language = language;
            this.Type = type;
            this.MediaRef = mediaRef;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Render" /> class.
        /// </summary>
        public Render()
        {
        }
    }
}