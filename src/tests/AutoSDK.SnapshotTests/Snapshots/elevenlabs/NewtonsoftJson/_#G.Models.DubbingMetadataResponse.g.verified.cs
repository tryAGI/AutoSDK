//HintName: G.Models.DubbingMetadataResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"created_at":"2025-07-15T14:49:41.149000","dubbing_id":"21m00Tcm4TlvDq8ikWAM","editable":true,"media_metadata":{"content_type":"video/mp4","duration":127.5},"name":"My Dubbing Project","source_language":"en","status":"dubbed","target_languages":["es","fr","de"]}
    /// </summary>
    public sealed partial class DubbingMetadataResponse
    {
        /// <summary>
        /// The ID of the dubbing project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dubbing_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DubbingId { get; set; } = default!;

        /// <summary>
        /// The name of the dubbing project.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The state this dub is in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// Once dubbing has completed, the ISO-639-1 code of the original media's source language.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_language")]
        public string? SourceLanguage { get; set; }

        /// <summary>
        /// The ISO-639-1 code of the languages this media has been dubbed into.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_languages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> TargetLanguages { get; set; } = default!;

        /// <summary>
        /// Whether this dubbing project is editable in Dubbing Studio.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("editable")]
        public bool? Editable { get; set; }

        /// <summary>
        /// Timestamp this dub was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Metadata, such as the length in seconds and content type, of the dubbed content.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("media_metadata")]
        public global::G.DubbingMediaMetadata? MediaMetadata { get; set; }

        /// <summary>
        /// Error message indicate, if this dub has failed, what happened.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMetadataResponse" /> class.
        /// </summary>
        /// <param name="dubbingId">
        /// The ID of the dubbing project.
        /// </param>
        /// <param name="name">
        /// The name of the dubbing project.
        /// </param>
        /// <param name="status">
        /// The state this dub is in.
        /// </param>
        /// <param name="targetLanguages">
        /// The ISO-639-1 code of the languages this media has been dubbed into.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp this dub was created.
        /// </param>
        /// <param name="sourceLanguage">
        /// Once dubbing has completed, the ISO-639-1 code of the original media's source language.
        /// </param>
        /// <param name="editable">
        /// Whether this dubbing project is editable in Dubbing Studio.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mediaMetadata">
        /// Metadata, such as the length in seconds and content type, of the dubbed content.
        /// </param>
        /// <param name="error">
        /// Error message indicate, if this dub has failed, what happened.
        /// </param>
        public DubbingMetadataResponse(
            string dubbingId,
            string name,
            string status,
            global::System.Collections.Generic.IList<string> targetLanguages,
            global::System.DateTime createdAt,
            string? sourceLanguage,
            bool? editable,
            global::G.DubbingMediaMetadata? mediaMetadata,
            string? error)
        {
            this.DubbingId = dubbingId ?? throw new global::System.ArgumentNullException(nameof(dubbingId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.SourceLanguage = sourceLanguage;
            this.TargetLanguages = targetLanguages ?? throw new global::System.ArgumentNullException(nameof(targetLanguages));
            this.Editable = editable;
            this.CreatedAt = createdAt;
            this.MediaMetadata = mediaMetadata;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingMetadataResponse" /> class.
        /// </summary>
        public DubbingMetadataResponse()
        {
        }
    }
}