//HintName: G.Models.TimeInterval.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeInterval
    {
        /// <summary>
        /// Start time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("begin")]
        public double? Begin { get; set; }

        /// <summary>
        /// End time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        public double? End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeInterval" /> class.
        /// </summary>
        /// <param name="begin">
        /// Start time in seconds
        /// </param>
        /// <param name="end">
        /// End time in seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeInterval(
            double? begin,
            double? end)
        {
            this.Begin = begin;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeInterval" /> class.
        /// </summary>
        public TimeInterval()
        {
        }
    }
}