//HintName: G.Models.ChartStackedBar.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a stacked bar in a stacked bar chart.<br/>
    /// Attributes:<br/>
    ///     label (list[str]): The labels for the stacked bars. Multiple values are stored<br/>
    ///         in cases where the chart is "double stacked," meaning bars are stacked both<br/>
    ///         horizontally and vertically.<br/>
    ///     values (list[tuple[str, int]]): A list of values representing different segments<br/>
    ///         of the stacked bar along with their label.
    /// </summary>
    public sealed partial class ChartStackedBar
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartStackedBar" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="values"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChartStackedBar(
            global::System.Collections.Generic.IList<string> label,
            global::System.Collections.Generic.IList<byte[]> values)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartStackedBar" /> class.
        /// </summary>
        public ChartStackedBar()
        {
        }
    }
}