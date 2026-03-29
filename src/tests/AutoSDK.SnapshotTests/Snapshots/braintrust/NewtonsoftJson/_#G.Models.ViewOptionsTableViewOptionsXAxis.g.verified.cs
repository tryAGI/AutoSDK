//HintName: G.Models.ViewOptionsTableViewOptionsXAxis.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViewOptionsTableViewOptionsXAxis
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ViewOptionsTableViewOptionsXAxisType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsTableViewOptionsXAxis" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public ViewOptionsTableViewOptionsXAxis(
            global::G.ViewOptionsTableViewOptionsXAxisType type,
            string value)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsTableViewOptionsXAxis" /> class.
        /// </summary>
        public ViewOptionsTableViewOptionsXAxis()
        {
        }
    }
}