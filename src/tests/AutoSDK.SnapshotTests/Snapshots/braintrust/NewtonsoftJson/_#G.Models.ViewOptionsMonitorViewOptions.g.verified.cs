//HintName: G.Models.ViewOptionsMonitorViewOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViewOptionsMonitorViewOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("viewType")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ViewOptionsMonitorViewOptionsViewTypeJsonConverter))]
        public global::G.ViewOptionsMonitorViewOptionsViewType ViewType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("options", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ViewOptionsMonitorViewOptionsOptions Options { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("freezeColumns")]
        public bool? FreezeColumns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsMonitorViewOptions" /> class.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="viewType"></param>
        /// <param name="freezeColumns"></param>
        public ViewOptionsMonitorViewOptions(
            global::G.ViewOptionsMonitorViewOptionsOptions options,
            global::G.ViewOptionsMonitorViewOptionsViewType viewType,
            bool? freezeColumns)
        {
            this.ViewType = viewType;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            this.FreezeColumns = freezeColumns;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsMonitorViewOptions" /> class.
        /// </summary>
        public ViewOptionsMonitorViewOptions()
        {
        }
    }
}