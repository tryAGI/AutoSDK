//HintName: G.Models.ComputerUseServerTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Computer use preview tool configuration
    /// </summary>
    public sealed partial class ComputerUseServerTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ComputerUseServerToolType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_height", Required = global::Newtonsoft.Json.Required.Always)]
        public double DisplayHeight { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_width", Required = global::Newtonsoft.Json.Required.Always)]
        public double DisplayWidth { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ComputerUseServerToolEnvironment Environment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseServerTool" /> class.
        /// </summary>
        /// <param name="displayHeight"></param>
        /// <param name="displayWidth"></param>
        /// <param name="environment"></param>
        /// <param name="type"></param>
        public ComputerUseServerTool(
            double displayHeight,
            double displayWidth,
            global::G.ComputerUseServerToolEnvironment environment,
            global::G.ComputerUseServerToolType type)
        {
            this.Type = type;
            this.DisplayHeight = displayHeight;
            this.DisplayWidth = displayWidth;
            this.Environment = environment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerUseServerTool" /> class.
        /// </summary>
        public ComputerUseServerTool()
        {
        }
    }
}