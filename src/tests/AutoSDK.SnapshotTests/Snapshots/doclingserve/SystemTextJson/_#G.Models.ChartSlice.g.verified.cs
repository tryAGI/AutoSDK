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
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSlice" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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