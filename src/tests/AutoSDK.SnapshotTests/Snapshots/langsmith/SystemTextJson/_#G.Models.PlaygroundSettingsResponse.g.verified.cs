//HintName: G.Models.PlaygroundSettingsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundSettingsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        public global::G.PlaygroundSavedOptions? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="settings"></param>
        /// <param name="options"></param>
        /// <param name="name"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundSettingsResponse(
            global::System.Guid id,
            object settings,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.PlaygroundSavedOptions? options,
            string? name,
            string? description)
        {
            this.Id = id;
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Options = options;
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsResponse" /> class.
        /// </summary>
        public PlaygroundSettingsResponse()
        {
        }
    }
}