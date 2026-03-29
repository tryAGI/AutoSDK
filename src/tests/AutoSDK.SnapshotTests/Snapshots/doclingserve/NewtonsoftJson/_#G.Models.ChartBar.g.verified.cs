//HintName: G.Models.ChartBar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a bar in a bar chart.<br/>
    /// Attributes:<br/>
    ///     label (str): The label for the bar.<br/>
    ///     values (float): The value associated with the bar.
    /// </summary>
    public sealed partial class ChartBar
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
        public double Values { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBar" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="values"></param>
        public ChartBar(
            string label,
            double values)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBar" /> class.
        /// </summary>
        public ChartBar()
        {
        }
    }
}