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
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBar" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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