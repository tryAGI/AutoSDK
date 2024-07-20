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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the tool being used.<br/>
        /// Example: get_weather
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// An object containing the input being passed to the tool, conforming to the tool’s `input_schema`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: tool_use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; } = "tool_use";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}