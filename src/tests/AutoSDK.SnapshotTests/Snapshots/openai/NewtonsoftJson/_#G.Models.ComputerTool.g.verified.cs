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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ComputerToolType Type { get; set; }

        /// <summary>
        /// The width of the computer display.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_width", Required = global::Newtonsoft.Json.Required.Always)]
        public double DisplayWidth { get; set; } = default!;

        /// <summary>
        /// The height of the computer display.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_height", Required = global::Newtonsoft.Json.Required.Always)]
        public double DisplayHeight { get; set; } = default!;

        /// <summary>
        /// The type of computer environment to control.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ComputerToolEnvironment Environment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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