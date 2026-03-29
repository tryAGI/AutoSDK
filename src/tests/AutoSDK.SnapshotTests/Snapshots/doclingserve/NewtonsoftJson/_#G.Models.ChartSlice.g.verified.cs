//HintName: G.Models.ChartSlice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a slice in a pie chart.<br/>
    /// Attributes:<br/>
    ///     label (str): The label for the slice.<br/>
    ///     value (float): The value represented by the slice.
    /// </summary>
    public sealed partial class ChartSlice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public string Label { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSlice" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="value"></param>
        public ChartSlice(
            string label,
            double value)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSlice" /> class.
        /// </summary>
        public ChartSlice()
        {
        }
    }
}