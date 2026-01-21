//HintName: G.Models.BetaComputerUseTool20250124.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaComputerUseTool20250124
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.CacheControlVariant15? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaComputerUseTool20250124Type Type { get; set; }

        /// <summary>
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in tool_use blocks.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public global::G.BetaComputerUseTool20250124Name Name { get; set; }

        /// <summary>
        /// The height of the display in pixels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_height_px", Required = global::Newtonsoft.Json.Required.Always)]
        public int DisplayHeightPx { get; set; } = default!;

        /// <summary>
        /// The width of the display in pixels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_width_px", Required = global::Newtonsoft.Json.Required.Always)]
        public int DisplayWidthPx { get; set; } = default!;

        /// <summary>
        /// The X11 display number (e.g. 0, 1) for the display.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_number")]
        public int? DisplayNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerUseTool20250124" /> class.
        /// </summary>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
        /// <param name="name">
        /// Name of the tool.<br/>
        /// This is how the tool will be called by the model and in tool_use blocks.
        /// </param>
        /// <param name="displayHeightPx">
        /// The height of the display in pixels.
        /// </param>
        /// <param name="displayWidthPx">
        /// The width of the display in pixels.
        /// </param>
        /// <param name="displayNumber">
        /// The X11 display number (e.g. 0, 1) for the display.
        /// </param>
        public BetaComputerUseTool20250124(
            int displayHeightPx,
            int displayWidthPx,
            global::G.CacheControlVariant15? cacheControl,
            global::G.BetaComputerUseTool20250124Type type,
            global::G.BetaComputerUseTool20250124Name name,
            int? displayNumber)
        {
            this.DisplayHeightPx = displayHeightPx;
            this.DisplayWidthPx = displayWidthPx;
            this.CacheControl = cacheControl;
            this.Type = type;
            this.Name = name;
            this.DisplayNumber = displayNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComputerUseTool20250124" /> class.
        /// </summary>
        public BetaComputerUseTool20250124()
        {
        }
    }
}