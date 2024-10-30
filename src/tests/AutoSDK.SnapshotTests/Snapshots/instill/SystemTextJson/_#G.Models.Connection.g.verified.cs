//HintName: G.Models.Connection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Connection contains the parameters to communicate with a 3rd party app. A<br/>
    /// component may reference a connection in their setup. One connection may be<br/>
    /// used by several components and pipelines.
    /// </summary>
    public sealed partial class Connection
    {
        /// <summary>
        /// UUID-formatted unique identifier.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the namespace owning the connection.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaceId")]
        public string? NamespaceId { get; set; }

        /// <summary>
        /// Integration ID. It determines for which type of components can reference<br/>
        /// this connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IntegrationId { get; set; }

        /// <summary>
        /// Integration title. This helps the console display the results grouped by<br/>
        /// integration ID without needing an extra call to fetch title by integration<br/>
        /// ID.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrationTitle")]
        public string? IntegrationTitle { get; set; }

        /// <summary>
        /// Connection method. It references the setup schema provided by the<br/>
        /// integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Method Method { get; set; }

        /// <summary>
        /// Connection details. This field is required on creation, optional on view.<br/>
        /// When viewing the connection details, the setup values will be redacted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Setup { get; set; }

        /// <summary>
        /// A list of scopes that identify the resources that the connection will be<br/>
        /// able to access on the user's behalf. This is typically passed on creation<br/>
        /// when the setup has been generated through an OAuth flow with a limited set<br/>
        /// of scopes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// When the connection method is METHOD_OAUTH, this field will hold the<br/>
        /// identity (e.g., email, username) with which the access token has been<br/>
        /// generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity")]
        public string? Identity { get; set; }

        /// <summary>
        /// When the connection method is METHOD_OAUTH, the access token might come<br/>
        /// with some extra information that might vary across vendors. This<br/>
        /// information is passed as connection metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oAuthAccessDetails")]
        public object? OAuthAccessDetails { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PipelineV1betaViewJsonConverter))]
        public global::G.PipelineV1betaView? View { get; set; }

        /// <summary>
        /// Creation timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Last update timestamp.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.Connection? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.Connection),
                jsonSerializerContext) as global::G.Connection;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Connection? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.Connection>(
                json,
                jsonSerializerOptions);
        }

    }
}