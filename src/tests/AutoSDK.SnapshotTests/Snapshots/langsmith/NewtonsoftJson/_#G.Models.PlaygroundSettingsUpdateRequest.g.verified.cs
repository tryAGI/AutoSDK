//HintName: G.Models.PlaygroundSettingsUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundSettingsUpdateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("settings")]
        public object? Settings { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options")]
        public global::G.PlaygroundSavedOptions? Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsUpdateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="settings"></param>
        /// <param name="options"></param>
        public PlaygroundSettingsUpdateRequest(
            string? name,
            string? description,
            object? settings,
            global::G.PlaygroundSavedOptions? options)
        {
            this.Name = name;
            this.Description = description;
            this.Settings = settings;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsUpdateRequest" /> class.
        /// </summary>
        public PlaygroundSettingsUpdateRequest()
        {
        }
    }
}