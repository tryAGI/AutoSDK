//HintName: G.Models.ChartLine.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a line in a line chart.<br/>
    /// Attributes:<br/>
    ///     label (str): The label for the line.<br/>
    ///     values (list[tuple[float, float]]): A list of (x, y) coordinate pairs<br/>
    ///         representing the line's data points.
    /// </summary>
    public sealed partial class ChartLine
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("values", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<byte[]> Values { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartLine" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="values"></param>
        public ChartLine(
            string label,
            global::System.Collections.Generic.IList<byte[]> values)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartLine" /> class.
        /// </summary>
        public ChartLine()
        {
        }
    }
}