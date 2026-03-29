//HintName: G.Models.Interval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Interval
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        public double? Default { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Interval" /> class.
        /// </summary>
        /// <param name="default"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Interval(
            double? @default,
            double? max,
            double? min)
        {
            this.Default = @default;
            this.Max = max;
            this.Min = min;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Interval" /> class.
        /// </summary>
        public Interval()
        {
        }
    }
}