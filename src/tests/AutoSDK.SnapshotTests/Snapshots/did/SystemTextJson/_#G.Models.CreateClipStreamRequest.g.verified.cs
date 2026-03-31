//HintName: G.Models.CreateClipStreamRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipStreamRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// a selection from the list or provided driver ids.<br/>
        /// Example: jack-Pt27VkP3hW
        /// </summary>
        /// <example>jack-Pt27VkP3hW</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// a selection from the list or provided driver ids.<br/>
        /// If not provided a driver video will be selected for you from the predefined drivers bank.<br/>
        /// Default Value: a5PgMbeGQE<br/>
        /// Example: a5PgMbeGQE
        /// </summary>
        /// <example>a5PgMbeGQE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("driver_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("script")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateClipStreamRequestScriptVariant1, global::G.CreateClipStreamRequestScriptVariant2>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.CreateClipStreamRequestScriptVariant1, global::G.CreateClipStreamRequestScriptVariant2> Script { get; set; }

        /// <summary>
        /// Advanced configuration options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::G.CreateClipStreamRequestConfig? Config { get; set; }

        /// <summary>
        /// The user created the clip.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Advanced presenter configuration options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presenter_config")]
        public global::G.CreateClipStreamRequestPresenterConfig? PresenterConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.CreateClipStreamRequestBackground? Background { get; set; }

        /// <summary>
        /// Non-sensitive custom data that will be added to the clip response and webhook.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// The name of the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The URL of the clip video, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/
        /// </summary>
        /// <example>https://path.to.directory/</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// Metadata passed to the clips worker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequest" /> class.
        /// </summary>
        /// <param name="script"></param>
        /// <param name="sessionId"></param>
        /// <param name="config">
        /// Advanced configuration options.
        /// </param>
        /// <param name="createdBy">
        /// The user created the clip.
        /// </param>
        /// <param name="presenterConfig">
        /// Advanced presenter configuration options.
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the clip response and webhook.
        /// </param>
        /// <param name="name">
        /// The name of the clip
        /// </param>
        /// <param name="resultUrl">
        /// The URL of the clip video, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/
        /// </param>
        /// <param name="metadata">
        /// Metadata passed to the clips worker
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateClipStreamRequest(
            global::G.AnyOf<global::G.CreateClipStreamRequestScriptVariant1, global::G.CreateClipStreamRequestScriptVariant2> script,
            string? sessionId,
            global::G.CreateClipStreamRequestConfig? config,
            string? createdBy,
            global::G.CreateClipStreamRequestPresenterConfig? presenterConfig,
            string? userData,
            string? name,
            string? resultUrl,
            object? metadata)
        {
            this.SessionId = sessionId;
            this.Script = script;
            this.Config = config;
            this.CreatedBy = createdBy;
            this.PresenterConfig = presenterConfig;
            this.UserData = userData;
            this.Name = name;
            this.ResultUrl = resultUrl;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequest" /> class.
        /// </summary>
        public CreateClipStreamRequest()
        {
        }
    }
}