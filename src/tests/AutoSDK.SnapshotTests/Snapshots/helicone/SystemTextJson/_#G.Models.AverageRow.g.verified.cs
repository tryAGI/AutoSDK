//HintName: G.Models.AverageRow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AverageRow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Average { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AverageRow" /> class.
        /// </summary>
        /// <param name="average"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AverageRow(
            double average)
        {
            this.Average = average;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AverageRow" /> class.
        /// </summary>
        public AverageRow()
        {
        }
    }
}