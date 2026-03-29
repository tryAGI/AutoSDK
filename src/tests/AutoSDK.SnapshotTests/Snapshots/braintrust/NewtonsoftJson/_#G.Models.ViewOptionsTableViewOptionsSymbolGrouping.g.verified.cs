//HintName: G.Models.ViewOptionsTableViewOptionsSymbolGrouping.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ViewOptionsTableViewOptionsSymbolGrouping
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ViewOptionsTableViewOptionsSymbolGroupingType Type { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ViewOptionsTableViewOptionsSymbolGrouping" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public ViewOptionsTableViewOptionsSymbolGrouping(
            global::G.ViewOptionsTableViewOptionsSymbolGroupingType type,
            string value)
        {
            this.Type = type;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewOptionsTableViewOptionsSymbolGrouping" /> class.
        /// </summary>
        public ViewOptionsTableViewOptionsSymbolGrouping()
        {
        }
    }
}