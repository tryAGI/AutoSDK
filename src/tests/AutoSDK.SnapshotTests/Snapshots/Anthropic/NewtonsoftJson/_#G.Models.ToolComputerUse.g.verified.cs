//HintName: G.Models.ToolComputerUse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that uses a mouse and keyboard to interact with a computer, and take screenshots.
    /// </summary>
    public sealed partial class ToolComputerUse
    {
        /// <summary>
        /// The type of tool.<br/>
        /// Default Value: computer_20241022
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The name of the tool.<br/>
        /// Default Value: computer
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The cache control settings.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_control")]
        public global::G.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// The width of the display in pixels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_width_px", Required = global::Newtonsoft.Json.Required.Always)]
        public int DisplayWidthPx { get; set; } = default!;

        /// <summary>
        /// The height of the display in pixels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_height_px", Required = global::Newtonsoft.Json.Required.Always)]
        public int DisplayHeightPx { get; set; } = default!;

        /// <summary>
        /// The number of the display to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_number")]
        public int? DisplayNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolComputerUse" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool.<br/>
        /// Default Value: computer_20241022
        /// </param>
        /// <param name="name">
        /// The name of the tool.<br/>
        /// Default Value: computer
        /// </param>
        /// <param name="cacheControl">
        /// The cache control settings.
        /// </param>
        /// <param name="displayWidthPx">
        /// The width of the display in pixels.
        /// </param>
        /// <param name="displayHeightPx">
        /// The height of the display in pixels.
        /// </param>
        /// <param name="displayNumber">
        /// The number of the display to use.
        /// </param>
        public ToolComputerUse(
            int displayWidthPx,
            int displayHeightPx,
            string? type,
            string? name,
            global::G.CacheControlEphemeral? cacheControl,
            int? displayNumber)
        {
            this.DisplayWidthPx = displayWidthPx;
            this.DisplayHeightPx = displayHeightPx;
            this.Type = type;
            this.Name = name;
            this.CacheControl = cacheControl;
            this.DisplayNumber = displayNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolComputerUse" /> class.
        /// </summary>
        public ToolComputerUse()
        {
        }
    }
}