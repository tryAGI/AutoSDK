//HintName: G.Models.PageDeployment.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The GitHub Pages deployment status.
    /// </summary>
    public sealed partial class PageDeployment
    {
        /// <summary>
        /// The ID of the GitHub Pages deployment. This is the Git SHA of the deployed commit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<int?, string> Id { get; set; } = default!;

        /// <summary>
        /// The URI to monitor GitHub Pages deployment status.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/pages/deployments/4fd754f7e594640989b406850d0bc8f06a121251
        /// </summary>
        /// <example>https://api.github.com/repos/github/hello-world/pages/deployments/4fd754f7e594640989b406850d0bc8f06a121251</example>
        [global::Newtonsoft.Json.JsonProperty("status_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string StatusUrl { get; set; } = default!;

        /// <summary>
        /// The URI to the deployed GitHub Pages.<br/>
        /// Example: hello-world.github.io
        /// </summary>
        /// <example>hello-world.github.io</example>
        [global::Newtonsoft.Json.JsonProperty("page_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PageUrl { get; set; } = default!;

        /// <summary>
        /// The URI to the deployed GitHub Pages preview.<br/>
        /// Example: monalisa-1231a2312sa32-23sda74.drafts.github.io
        /// </summary>
        /// <example>monalisa-1231a2312sa32-23sda74.drafts.github.io</example>
        [global::Newtonsoft.Json.JsonProperty("preview_url")]
        public string? PreviewUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PageDeployment" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the GitHub Pages deployment. This is the Git SHA of the deployed commit.
        /// </param>
        /// <param name="statusUrl">
        /// The URI to monitor GitHub Pages deployment status.<br/>
        /// Example: https://api.github.com/repos/github/hello-world/pages/deployments/4fd754f7e594640989b406850d0bc8f06a121251
        /// </param>
        /// <param name="pageUrl">
        /// The URI to the deployed GitHub Pages.<br/>
        /// Example: hello-world.github.io
        /// </param>
        /// <param name="previewUrl">
        /// The URI to the deployed GitHub Pages preview.<br/>
        /// Example: monalisa-1231a2312sa32-23sda74.drafts.github.io
        /// </param>
        public PageDeployment(
            global::G.OneOf<int?, string> id,
            string statusUrl,
            string pageUrl,
            string? previewUrl)
        {
            this.Id = id;
            this.StatusUrl = statusUrl ?? throw new global::System.ArgumentNullException(nameof(statusUrl));
            this.PageUrl = pageUrl ?? throw new global::System.ArgumentNullException(nameof(pageUrl));
            this.PreviewUrl = previewUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PageDeployment" /> class.
        /// </summary>
        public PageDeployment()
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
        public static global::G.PageDeployment? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PageDeployment>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.PageDeployment?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.PageDeployment?>(serializer.Deserialize<global::G.PageDeployment>(jsonReader));
        }

    }
}