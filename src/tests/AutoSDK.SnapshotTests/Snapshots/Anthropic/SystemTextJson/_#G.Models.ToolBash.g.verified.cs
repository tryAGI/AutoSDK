//HintName: G.Models.ToolBash.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool for running commands in a bash shell.
    /// </summary>
    public sealed partial class ToolBash
    {
        /// <summary>
        /// The type of tool.<br/>
        /// Default Value: bash_20241022
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The name of the tool.<br/>
        /// Default Value: bash
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The cache control settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::G.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolBash" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool.<br/>
        /// Default Value: bash_20241022
        /// </param>
        /// <param name="name">
        /// The name of the tool.<br/>
        /// Default Value: bash
        /// </param>
        /// <param name="cacheControl">
        /// The cache control settings.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ToolBash(
            string? type,
            string? name,
            global::G.CacheControlEphemeral? cacheControl)
        {
            this.Type = type;
            this.Name = name;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolBash" /> class.
        /// </summary>
        public ToolBash()
        {
        }
    }
}