//HintName: G.Models.ComputerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that controls a virtual computer. Learn more about the <br/>
    /// [computer tool](/docs/guides/tools-computer-use).
    /// </summary>
    public sealed partial class ComputerTool
    {
        /// <summary>
        /// The type of the computer use tool. Always `computer_use_preview`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ComputerToolTypeJsonConverter))]
        public global::G.ComputerToolType Type { get; set; }

        /// <summary>
        /// The width of the computer display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DisplayWidth { get; set; }

        /// <summary>
        /// The height of the computer display.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DisplayHeight { get; set; }

        /// <summary>
        /// The type of computer environment to control.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ComputerToolEnvironmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ComputerToolEnvironment Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the computer use tool. Always `computer_use_preview`.
        /// </param>
        /// <param name="displayWidth">
        /// The width of the computer display.
        /// </param>
        /// <param name="displayHeight">
        /// The height of the computer display.
        /// </param>
        /// <param name="environment">
        /// The type of computer environment to control.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComputerTool(
            double displayWidth,
            double displayHeight,
            global::G.ComputerToolEnvironment environment,
            global::G.ComputerToolType type)
        {
            this.DisplayWidth = displayWidth;
            this.DisplayHeight = displayHeight;
            this.Environment = environment;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerTool" /> class.
        /// </summary>
        public ComputerTool()
        {
        }
    }
}