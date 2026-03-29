//HintName: G.Models.CreateTalkStreamRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTalkStreamRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// The URL of the driver video to drive the talk, or a selection from the list or provided drivers.<br/>
        /// If not provided a driver video will be selected for you from the predefined drivers bank.<br/>
        /// Example: bank://natural
        /// </summary>
        /// <example>bank://natural</example>
        [global::Newtonsoft.Json.JsonProperty("driver_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? DriverUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.CreateTalkStreamRequestScriptVariant1, global::G.CreateTalkStreamRequestScriptVariant2> Script { get; set; } = default!;

        /// <summary>
        /// Advanced configuration options.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.AllOf<global::G.CreateTalkStreamRequestConfigVariant1, global::G.CreateTalkStreamRequestConfigVariant2>? Config { get; set; }

        /// <summary>
        /// Non-sensitive custom data that will be added to the talk response and webhook.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_data")]
        public string? UserData { get; set; }

        /// <summary>
        /// The name of the talk video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The optimization level of the audio<br/>
        /// Default Value: 2
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_optimization")]
        public double? AudioOptimization { get; set; }

        /// <summary>
        /// Metadata passed to the talks worker
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkStreamRequest" /> class.
        /// </summary>
        /// <param name="script"></param>
        /// <param name="sessionId"></param>
        /// <param name="config">
        /// Advanced configuration options.
        /// </param>
        /// <param name="userData">
        /// Non-sensitive custom data that will be added to the talk response and webhook.
        /// </param>
        /// <param name="name">
        /// The name of the talk video
        /// </param>
        /// <param name="audioOptimization">
        /// The optimization level of the audio<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="metadata">
        /// Metadata passed to the talks worker
        /// </param>
        public CreateTalkStreamRequest(
            global::G.AnyOf<global::G.CreateTalkStreamRequestScriptVariant1, global::G.CreateTalkStreamRequestScriptVariant2> script,
            string? sessionId,
            global::G.AllOf<global::G.CreateTalkStreamRequestConfigVariant1, global::G.CreateTalkStreamRequestConfigVariant2>? config,
            string? userData,
            string? name,
            double? audioOptimization,
            object? metadata)
        {
            this.SessionId = sessionId;
            this.Script = script;
            this.Config = config;
            this.UserData = userData;
            this.Name = name;
            this.AudioOptimization = audioOptimization;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTalkStreamRequest" /> class.
        /// </summary>
        public CreateTalkStreamRequest()
        {
        }
    }
}