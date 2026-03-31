//HintName: G.Models.Error.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Error
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_generation")]
        public string? FailedGeneration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_path")]
        public string? SchemaPath { get; set; }

        /// <summary>
        /// Segments of the schema path relevant to validation errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_path_segments")]
        public global::System.Collections.Generic.IList<string>? SchemaPathSegments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_kind")]
        public string? SchemaKind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema_code")]
        public string? SchemaCode { get; set; }

        /// <summary>
        /// Debug information including input and output token IDs and strings. Only present when debug=true in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debug")]
        public global::G.DebugData? Debug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type"></param>
        /// <param name="param"></param>
        /// <param name="code"></param>
        /// <param name="failedGeneration"></param>
        /// <param name="schemaPath"></param>
        /// <param name="schemaPathSegments">
        /// Segments of the schema path relevant to validation errors.
        /// </param>
        /// <param name="schemaKind"></param>
        /// <param name="schemaCode"></param>
        /// <param name="debug">
        /// Debug information including input and output token IDs and strings. Only present when debug=true in the request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error(
            string message,
            string type,
            string? param,
            string? code,
            string? failedGeneration,
            string? schemaPath,
            global::System.Collections.Generic.IList<string>? schemaPathSegments,
            string? schemaKind,
            string? schemaCode,
            global::G.DebugData? debug)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Param = param;
            this.Code = code;
            this.FailedGeneration = failedGeneration;
            this.SchemaPath = schemaPath;
            this.SchemaPathSegments = schemaPathSegments;
            this.SchemaKind = schemaKind;
            this.SchemaCode = schemaCode;
            this.Debug = debug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        public Error()
        {
        }
    }
}