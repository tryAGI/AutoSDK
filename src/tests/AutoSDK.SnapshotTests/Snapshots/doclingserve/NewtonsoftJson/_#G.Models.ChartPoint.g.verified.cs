//HintName: G.Models.ChartPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a point in a scatter chart.<br/>
    /// Attributes:<br/>
    ///     value (Tuple[float, float]): A (x, y) coordinate pair representing a point in a<br/>
    ///         chart.
    /// </summary>
    public sealed partial class ChartPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartPoint" /> class.
        /// </summary>
        /// <param name="value"></param>
        public ChartPoint(
            byte[] value)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartPoint" /> class.
        /// </summary>
        public ChartPoint()
        {
        }
    }
}