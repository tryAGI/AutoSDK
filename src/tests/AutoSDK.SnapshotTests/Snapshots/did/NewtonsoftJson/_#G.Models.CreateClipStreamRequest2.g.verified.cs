//HintName: G.Models.CreateClipStreamRequest2.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipStreamRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// a selection from the list or provided driver ids.<br/>
        /// Example: jack-Pt27VkP3hW
        /// </summary>
        /// <example>jack-Pt27VkP3hW</example>
        [global::Newtonsoft.Json.JsonProperty("presenter_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PresenterId { get; set; }

        /// <summary>
        /// a selection from the list or provided driver ids.<br/>
        /// If not provided a driver video will be selected for you from the predefined drivers bank.<br/>
        /// Default Value: a5PgMbeGQE<br/>
        /// Example: a5PgMbeGQE
        /// </summary>
        /// <example>a5PgMbeGQE</example>
        [global::Newtonsoft.Json.JsonProperty("driver_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? DriverId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.CreateClipStreamRequestScriptVariant12, global::G.CreateClipStreamRequestScriptVariant22> Script { get; set; } = default!;

        /// <summary>
        /// Advanced configuration options.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.CreateClipStreamRequestConfig2? Config { get; set; }

        /// <summary>
        /// The user created the clip.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Advanced presenter configuration options.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presenter_config")]
        public global::G.CreateClipStreamRequestPresenterConfig2? PresenterConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("background")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.CreateClipStreamRequestBackground2? Background { get; set; }

        /// <summary>
        /// Non-sensitive custom data that will be added to the clip response and webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// The name of the clip
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The URL of the clip video, if not provided use default destination.<br/>
        /// Example: https://path.to.directory/
        /// </summary>
        /// <example>https://path.to.directory/</example>
        [global::Newtonsoft.Json.JsonProperty("result_url")]
        public string? ResultUrl { get; set; }

        /// <summary>
        /// Metadata passed to the clips worker
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequest2" /> class.
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
        public CreateClipStreamRequest2(
            global::G.AnyOf<global::G.CreateClipStreamRequestScriptVariant12, global::G.CreateClipStreamRequestScriptVariant22> script,
            string? sessionId,
            global::G.CreateClipStreamRequestConfig2? config,
            string? createdBy,
            global::G.CreateClipStreamRequestPresenterConfig2? presenterConfig,
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
        /// Initializes a new instance of the <see cref="CreateClipStreamRequest2" /> class.
        /// </summary>
        public CreateClipStreamRequest2()
        {
        }
    }
}