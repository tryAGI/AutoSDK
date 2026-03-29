//HintName: G.Models.ApiMlPartialUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiMlPartialUpdateRequest
    {
        /// <summary>
        /// Auth method
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ApiMlPartialUpdateRequestAuthMethodJsonConverter))]
        public global::G.ApiMlPartialUpdateRequestAuthMethod? AuthMethod { get; set; }

        /// <summary>
        /// Basic auth password
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic_auth_pass")]
        public string? BasicAuthPass { get; set; }

        /// <summary>
        /// Basic auth user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("basic_auth_user")]
        public string? BasicAuthUser { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Extra parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_params")]
        public object? ExtraParams { get; set; }

        /// <summary>
        /// Is interactive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_interactive")]
        public bool? IsInteractive { get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        public int? Project { get; set; }

        /// <summary>
        /// Response model timeout
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// ML backend URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMlPartialUpdateRequest" /> class.
        /// </summary>
        /// <param name="authMethod">
        /// Auth method
        /// </param>
        /// <param name="basicAuthPass">
        /// Basic auth password
        /// </param>
        /// <param name="basicAuthUser">
        /// Basic auth user
        /// </param>
        /// <param name="description">
        /// Description
        /// </param>
        /// <param name="extraParams">
        /// Extra parameters
        /// </param>
        /// <param name="isInteractive">
        /// Is interactive
        /// </param>
        /// <param name="project">
        /// Project ID
        /// </param>
        /// <param name="timeout">
        /// Response model timeout
        /// </param>
        /// <param name="title">
        /// Title
        /// </param>
        /// <param name="url">
        /// ML backend URL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiMlPartialUpdateRequest(
            global::G.ApiMlPartialUpdateRequestAuthMethod? authMethod,
            string? basicAuthPass,
            string? basicAuthUser,
            string? description,
            object? extraParams,
            bool? isInteractive,
            int? project,
            int? timeout,
            string? title,
            string? url)
        {
            this.AuthMethod = authMethod;
            this.BasicAuthPass = basicAuthPass;
            this.BasicAuthUser = basicAuthUser;
            this.Description = description;
            this.ExtraParams = extraParams;
            this.IsInteractive = isInteractive;
            this.Project = project;
            this.Timeout = timeout;
            this.Title = title;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMlPartialUpdateRequest" /> class.
        /// </summary>
        public ApiMlPartialUpdateRequest()
        {
        }
    }
}