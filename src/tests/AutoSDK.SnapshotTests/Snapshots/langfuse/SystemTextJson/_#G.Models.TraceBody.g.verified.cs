//HintName: G.Models.TraceBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TraceBody
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release")]
        public string? Release { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Make trace publicly accessible via url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceBody" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="timestamp"></param>
        /// <param name="name"></param>
        /// <param name="userId"></param>
        /// <param name="input"></param>
        /// <param name="output"></param>
        /// <param name="sessionId"></param>
        /// <param name="release"></param>
        /// <param name="version"></param>
        /// <param name="metadata"></param>
        /// <param name="tags"></param>
        /// <param name="environment"></param>
        /// <param name="public">
        /// Make trace publicly accessible via url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TraceBody(
            string? id,
            global::System.DateTime? timestamp,
            string? name,
            string? userId,
            object? input,
            object? output,
            string? sessionId,
            string? release,
            string? version,
            object? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            string? environment,
            bool? @public)
        {
            this.Id = id;
            this.Timestamp = timestamp;
            this.Name = name;
            this.UserId = userId;
            this.Input = input;
            this.Output = output;
            this.SessionId = sessionId;
            this.Release = release;
            this.Version = version;
            this.Metadata = metadata;
            this.Tags = tags;
            this.Environment = environment;
            this.Public = @public;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TraceBody" /> class.
        /// </summary>
        public TraceBody()
        {
        }
    }
}