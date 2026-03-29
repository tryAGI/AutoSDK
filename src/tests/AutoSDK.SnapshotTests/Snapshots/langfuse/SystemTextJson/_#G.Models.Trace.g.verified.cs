//HintName: G.Models.Trace.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Trace
    {
        /// <summary>
        /// The unique identifier of a trace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The timestamp when the trace was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// The name of the trace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The input data of the trace. Can be any JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// The output data of the trace. Can be any JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public object? Output { get; set; }

        /// <summary>
        /// The session identifier associated with the trace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The release version of the application when the trace was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("release")]
        public string? Release { get; set; }

        /// <summary>
        /// The version of the trace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The user identifier associated with the trace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// The metadata associated with the trace. Can be any JSON.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The tags associated with the trace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Tags { get; set; }

        /// <summary>
        /// Public traces are accessible via url without login
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Public { get; set; }

        /// <summary>
        /// The environment from which this trace originated. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Trace" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of a trace
        /// </param>
        /// <param name="timestamp">
        /// The timestamp when the trace was created
        /// </param>
        /// <param name="tags">
        /// The tags associated with the trace.
        /// </param>
        /// <param name="public">
        /// Public traces are accessible via url without login
        /// </param>
        /// <param name="environment">
        /// The environment from which this trace originated. Can be any lowercase alphanumeric string with hyphens and underscores that does not start with 'langfuse'.
        /// </param>
        /// <param name="name">
        /// The name of the trace
        /// </param>
        /// <param name="input">
        /// The input data of the trace. Can be any JSON.
        /// </param>
        /// <param name="output">
        /// The output data of the trace. Can be any JSON.
        /// </param>
        /// <param name="sessionId">
        /// The session identifier associated with the trace
        /// </param>
        /// <param name="release">
        /// The release version of the application when the trace was created
        /// </param>
        /// <param name="version">
        /// The version of the trace
        /// </param>
        /// <param name="userId">
        /// The user identifier associated with the trace
        /// </param>
        /// <param name="metadata">
        /// The metadata associated with the trace. Can be any JSON.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Trace(
            string id,
            global::System.DateTime timestamp,
            global::System.Collections.Generic.IList<string> tags,
            bool @public,
            string environment,
            string? name,
            object? input,
            object? output,
            string? sessionId,
            string? release,
            string? version,
            string? userId,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Timestamp = timestamp;
            this.Name = name;
            this.Input = input;
            this.Output = output;
            this.SessionId = sessionId;
            this.Release = release;
            this.Version = version;
            this.UserId = userId;
            this.Metadata = metadata;
            this.Tags = tags ?? throw new global::System.ArgumentNullException(nameof(tags));
            this.Public = @public;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Trace" /> class.
        /// </summary>
        public Trace()
        {
        }
    }
}