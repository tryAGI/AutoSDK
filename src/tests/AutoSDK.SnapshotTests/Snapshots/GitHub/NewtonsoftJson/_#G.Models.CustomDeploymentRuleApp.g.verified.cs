//HintName: G.Models.CustomDeploymentRuleApp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A GitHub App that is providing a custom deployment protection rule.
    /// </summary>
    public sealed partial class CustomDeploymentRuleApp
    {
        /// <summary>
        /// The unique identifier of the deployment protection rule integration.<br/>
        /// Example: 3515
        /// </summary>
        /// <example>3515</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The slugified name of the deployment protection rule integration.<br/>
        /// Example: my-custom-app
        /// </summary>
        /// <example>my-custom-app</example>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// The URL for the endpoint to get details about the app.<br/>
        /// Example: https://api.github.com/apps/custom-app-slug
        /// </summary>
        /// <example>https://api.github.com/apps/custom-app-slug</example>
        [global::Newtonsoft.Json.JsonProperty("integration_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string IntegrationUrl { get; set; } = default!;

        /// <summary>
        /// The node ID for the deployment protection rule integration.<br/>
        /// Example: MDQ6R2F0ZTM1MTU=
        /// </summary>
        /// <example>MDQ6R2F0ZTM1MTU=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDeploymentRuleApp" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the deployment protection rule integration.<br/>
        /// Example: 3515
        /// </param>
        /// <param name="slug">
        /// The slugified name of the deployment protection rule integration.<br/>
        /// Example: my-custom-app
        /// </param>
        /// <param name="integrationUrl">
        /// The URL for the endpoint to get details about the app.<br/>
        /// Example: https://api.github.com/apps/custom-app-slug
        /// </param>
        /// <param name="nodeId">
        /// The node ID for the deployment protection rule integration.<br/>
        /// Example: MDQ6R2F0ZTM1MTU=
        /// </param>
        public CustomDeploymentRuleApp(
            int id,
            string slug,
            string integrationUrl,
            string nodeId)
        {
            this.Id = id;
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.IntegrationUrl = integrationUrl ?? throw new global::System.ArgumentNullException(nameof(integrationUrl));
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDeploymentRuleApp" /> class.
        /// </summary>
        public CustomDeploymentRuleApp()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.CustomDeploymentRuleApp? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.CustomDeploymentRuleApp>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.CustomDeploymentRuleApp?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.CustomDeploymentRuleApp?>(serializer.Deserialize<global::G.CustomDeploymentRuleApp>(jsonReader));
        }

    }
}