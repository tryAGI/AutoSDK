//HintName: G.Models.Organization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Organization
    {
        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Name of the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_url")]
        public string? ApiUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_universal_api")]
        public bool? IsUniversalApi { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_dataplane_private")]
        public bool? IsDataplanePrivate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_url")]
        public string? ProxyUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("realtime_url")]
        public string? RealtimeUrl { get; set; }

        /// <summary>
        /// Date of organization creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public global::System.DateTime? Created { get; set; }

        /// <summary>
        /// Controls how images are rendered in the UI: 'auto' loads images automatically, 'click_to_load' shows a placeholder until clicked, 'blocked' prevents image loading entirely
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_rendering_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageRenderingModeJsonConverter))]
        public global::G.ImageRenderingMode? ImageRenderingMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the organization
        /// </param>
        /// <param name="name">
        /// Name of the organization
        /// </param>
        /// <param name="apiUrl"></param>
        /// <param name="isUniversalApi"></param>
        /// <param name="isDataplanePrivate"></param>
        /// <param name="proxyUrl"></param>
        /// <param name="realtimeUrl"></param>
        /// <param name="created">
        /// Date of organization creation
        /// </param>
        /// <param name="imageRenderingMode">
        /// Controls how images are rendered in the UI: 'auto' loads images automatically, 'click_to_load' shows a placeholder until clicked, 'blocked' prevents image loading entirely
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Organization(
            global::System.Guid id,
            string name,
            string? apiUrl,
            bool? isUniversalApi,
            bool? isDataplanePrivate,
            string? proxyUrl,
            string? realtimeUrl,
            global::System.DateTime? created,
            global::G.ImageRenderingMode? imageRenderingMode)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ApiUrl = apiUrl;
            this.IsUniversalApi = isUniversalApi;
            this.IsDataplanePrivate = isDataplanePrivate;
            this.ProxyUrl = proxyUrl;
            this.RealtimeUrl = realtimeUrl;
            this.Created = created;
            this.ImageRenderingMode = imageRenderingMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        public Organization()
        {
        }
    }
}