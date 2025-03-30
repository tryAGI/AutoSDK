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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings", Required = global::Newtonsoft.Json.Required.Always)]
        public object Settings { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.PlaygroundSavedOptions? Options { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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