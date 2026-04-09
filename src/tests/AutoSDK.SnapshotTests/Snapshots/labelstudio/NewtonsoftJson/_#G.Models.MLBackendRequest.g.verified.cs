//HintName: G.Models.MLBackendRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for MLBackend model.
    /// </summary>
    public sealed partial class MLBackendRequest
    {
        /// <summary>
        /// * `NONE` - None<br/>
        /// * `BASIC_AUTH` - Basic Auth
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auth_method")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AuthMethodEnumJsonConverter))]
        public global::G.AuthMethodEnum? AuthMethod { get; set; }

        /// <summary>
        /// If false, model version is set by the user, if true - getting latest version from backend.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_update")]
        public bool? AutoUpdate { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("basic_auth_pass")]
        public string? BasicAuthPass { get; set; }

        /// <summary>
        /// HTTP Basic Auth user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("basic_auth_user")]
        public string? BasicAuthUser { get; set; }

        /// <summary>
        /// Description for the machine learning backend
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Error message in error state
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Any extra parameters passed to the ML Backend during the setup
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra_params")]
        public object? ExtraParams { get; set; }

        /// <summary>
        /// Used to interactively annotate tasks. If true, model returns one list with results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_interactive")]
        public bool? IsInteractive { get; set; }

        /// <summary>
        /// Current model version associated with this machine learning backend
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public int Project { get; set; } = default!;

        /// <summary>
        /// * `CO` - Connected<br/>
        /// * `DI` - Disconnected<br/>
        /// * `ER` - Error<br/>
        /// * `TR` - Training<br/>
        /// * `PR` - Predicting
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("state")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.StateEnumJsonConverter))]
        public global::G.StateEnum? State { get; set; }

        /// <summary>
        /// Response model timeout
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Name of the machine learning backend
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// URL for the machine learning model server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MLBackendRequest" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="url">
        /// URL for the machine learning model server
        /// </param>
        /// <param name="authMethod">
        /// * `NONE` - None<br/>
        /// * `BASIC_AUTH` - Basic Auth
        /// </param>
        /// <param name="autoUpdate">
        /// If false, model version is set by the user, if true - getting latest version from backend.
        /// </param>
        /// <param name="basicAuthPass">
        /// Included only in requests
        /// </param>
        /// <param name="basicAuthUser">
        /// HTTP Basic Auth user
        /// </param>
        /// <param name="description">
        /// Description for the machine learning backend
        /// </param>
        /// <param name="errorMessage">
        /// Error message in error state
        /// </param>
        /// <param name="extraParams">
        /// Any extra parameters passed to the ML Backend during the setup
        /// </param>
        /// <param name="isInteractive">
        /// Used to interactively annotate tasks. If true, model returns one list with results
        /// </param>
        /// <param name="modelVersion">
        /// Current model version associated with this machine learning backend
        /// </param>
        /// <param name="state">
        /// * `CO` - Connected<br/>
        /// * `DI` - Disconnected<br/>
        /// * `ER` - Error<br/>
        /// * `TR` - Training<br/>
        /// * `PR` - Predicting
        /// </param>
        /// <param name="timeout">
        /// Response model timeout
        /// </param>
        /// <param name="title">
        /// Name of the machine learning backend
        /// </param>
        public MLBackendRequest(
            int project,
            string url,
            global::G.AuthMethodEnum? authMethod,
            bool? autoUpdate,
            string? basicAuthPass,
            string? basicAuthUser,
            string? description,
            string? errorMessage,
            object? extraParams,
            bool? isInteractive,
            string? modelVersion,
            global::G.StateEnum? state,
            double? timeout,
            string? title)
        {
            this.AuthMethod = authMethod;
            this.AutoUpdate = autoUpdate;
            this.BasicAuthPass = basicAuthPass;
            this.BasicAuthUser = basicAuthUser;
            this.Description = description;
            this.ErrorMessage = errorMessage;
            this.ExtraParams = extraParams;
            this.IsInteractive = isInteractive;
            this.ModelVersion = modelVersion;
            this.Project = project;
            this.State = state;
            this.Timeout = timeout;
            this.Title = title;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MLBackendRequest" /> class.
        /// </summary>
        public MLBackendRequest()
        {
        }
    }
}