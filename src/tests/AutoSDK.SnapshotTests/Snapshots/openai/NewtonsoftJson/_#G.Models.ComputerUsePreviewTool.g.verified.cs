//HintName: G.Models.ComputerUsePreviewTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that controls a virtual computer. Learn more about the [computer tool](https://platform.openai.com/docs/guides/tools-computer-use).
    /// </summary>
    public sealed partial class ComputerUsePreviewTool
    {
        /// <summary>
        /// The type of the computer use tool. Always `computer_use_preview`.<br/>
        /// Default Value: computer_use_preview
        /// </summary>
        /// <default>global::G.ComputerUsePreviewToolType.ComputerUsePreview</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ComputerUsePreviewToolType Type { get; set; } = global::G.ComputerUsePreviewToolType.ComputerUsePreview;

        /// <summary>
        /// The type of computer environment to control.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ComputerUsePreviewToolEnvironment Environment { get; set; } = default!;

        /// <summary>
        /// The width of the computer display.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_width", Required = global::Newtonsoft.Json.Required.Always)]
        public int DisplayWidth { get; set; } = default!;

        /// <summary>
        /// The height of the computer display.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_height", Required = global::Newtonsoft.Json.Required.Always)]
        public int DisplayHeight { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUsePreviewTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the computer use tool. Always `computer_use_preview`.<br/>
        /// Default Value: computer_use_preview
        /// </param>
        /// <param name="environment">
        /// The type of computer environment to control.
        /// </param>
        /// <param name="displayWidth">
        /// The width of the computer display.
        /// </param>
        /// <param name="displayHeight">
        /// The height of the computer display.
        /// </param>
        public ComputerUsePreviewTool(
            global::G.ComputerUsePreviewToolEnvironment environment,
            int displayWidth,
            int displayHeight,
            global::G.ComputerUsePreviewToolType type = global::G.ComputerUsePreviewToolType.ComputerUsePreview)
        {
            this.Environment = environment;
            this.DisplayWidth = displayWidth;
            this.DisplayHeight = displayHeight;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUsePreviewTool" /> class.
        /// </summary>
        public ComputerUsePreviewTool()
        {
        }
    }
}