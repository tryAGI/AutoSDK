//HintName: G.Models.ToolUseBlock.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The tool the model wants to use.
    /// </summary>
    public sealed partial class ToolUseBlock
    {
        /// <summary>
        /// A unique identifier for this particular tool use block. <br/>
        /// This will be used to match up the tool results later.<br/>
        /// Example: toolu_01A09q90qw90lq917835lq9
        /// </summary>
        /// <example>toolu_01A09q90qw90lq917835lq9</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The name of the tool being used.<br/>
        /// Example: get_weather
        /// </summary>
        /// <example>get_weather</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// An object containing the input being passed to the tool, conforming to the tool's `input_schema`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public object Input { get; set; } = default!;

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: tool_use
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The cache control settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolUseBlock" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for this particular tool use block. <br/>
        /// This will be used to match up the tool results later.<br/>
        /// Example: toolu_01A09q90qw90lq917835lq9
        /// </param>
        /// <param name="name">
        /// The name of the tool being used.<br/>
        /// Example: get_weather
        /// </param>
        /// <param name="input">
        /// An object containing the input being passed to the tool, conforming to the tool's `input_schema`.
        /// </param>
        /// <param name="type">
        /// The type of content block.<br/>
        /// Default Value: tool_use
        /// </param>
        /// <param name="cacheControl">
        /// The cache control settings.
        /// </param>
        public ToolUseBlock(
            string id,
            string name,
            object input,
            string? type,
            global::G.CacheControlEphemeral? cacheControl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Type = type;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolUseBlock" /> class.
        /// </summary>
        public ToolUseBlock()
        {
        }
    }
}