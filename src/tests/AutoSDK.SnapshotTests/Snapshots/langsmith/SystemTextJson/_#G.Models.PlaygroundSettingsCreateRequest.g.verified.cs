//HintName: G.Models.PlaygroundSettingsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaygroundSettingsCreateRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsCreateRequest" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="settings"></param>
        /// <param name="options"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaygroundSettingsCreateRequest(
            object settings,
            string? name,
            string? description,
            global::G.PlaygroundSavedOptions? options)
        {
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.Name = name;
            this.Description = description;
            this.Options = options;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaygroundSettingsCreateRequest" /> class.
        /// </summary>
        public PlaygroundSettingsCreateRequest()
        {
        }
    }
}