//HintName: G.Models.MLBackend.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for MLBackend model.
    /// </summary>
    public sealed partial class MLBackend
    {
        /// <summary>
        /// * `NONE` - None<br/>
        /// * `BASIC_AUTH` - Basic Auth
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AuthMethodEnumJsonConverter))]
        public global::G.AuthMethodEnum? AuthMethod { get; set; }

        /// <summary>
        /// If false, model version is set by the user, if true - getting latest version from backend.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_update")]
        public bool? AutoUpdate { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic_auth_pass_is_set")]
        public bool BasicAuthPassIsSet { get; set; } = default!;

        /// <summary>
        /// HTTP Basic Auth user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic_auth_user")]
        public string? BasicAuthUser { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Description for the machine learning backend
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Error message in error state
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Any extra parameters passed to the ML Backend during the setup
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_params")]
        public object? ExtraParams { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Used to interactively annotate tasks. If true, model returns one list with results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_interactive")]
        public bool? IsInteractive { get; set; }

        /// <summary>
        /// Current model version associated with this machine learning backend
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        public string? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Project { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("readable_state")]
        public string ReadableState { get; set; } = default!;

        /// <summary>
        /// * `CO` - Connected<br/>
        /// * `DI` - Disconnected<br/>
        /// * `ER` - Error<br/>
        /// * `TR` - Training<br/>
        /// * `PR` - Predicting
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StateEnumJsonConverter))]
        public global::G.StateEnum? State { get; set; }

        /// <summary>
        /// Response model timeout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Name of the machine learning backend
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// URL for the machine learning model server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MLBackend" /> class.
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
        /// <param name="basicAuthPassIsSet">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="readableState">
        /// Included only in responses
        /// </param>
        /// <param name="updatedAt">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MLBackend(
            int project,
            string url,
            global::G.AuthMethodEnum? authMethod,
            bool? autoUpdate,
            string? basicAuthUser,
            string? description,
            string? errorMessage,
            object? extraParams,
            bool? isInteractive,
            string? modelVersion,
            global::G.StateEnum? state,
            double? timeout,
            string? title,
            bool basicAuthPassIsSet = default!,
            global::System.DateTime createdAt = default!,
            int id = default!,
            string readableState = default!,
            global::System.DateTime updatedAt = default!)
        {
            this.AuthMethod = authMethod;
            this.AutoUpdate = autoUpdate;
            this.BasicAuthPassIsSet = basicAuthPassIsSet;
            this.BasicAuthUser = basicAuthUser;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.ErrorMessage = errorMessage;
            this.ExtraParams = extraParams;
            this.Id = id;
            this.IsInteractive = isInteractive;
            this.ModelVersion = modelVersion;
            this.Project = project;
            this.ReadableState = readableState;
            this.State = state;
            this.Timeout = timeout;
            this.Title = title;
            this.UpdatedAt = updatedAt;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MLBackend" /> class.
        /// </summary>
        public MLBackend()
        {
        }
    }
}