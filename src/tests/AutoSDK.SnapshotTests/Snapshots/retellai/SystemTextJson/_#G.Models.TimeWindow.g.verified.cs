//HintName: G.Models.TimeWindow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeWindow
    {
        /// <summary>
        /// Start time in minutes since local midnight.<br/>
        /// Example: 540
        /// </summary>
        /// <example>540</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Start { get; set; }

        /// <summary>
        /// End time in minutes since local midnight.<br/>
        /// Example: 1020
        /// </summary>
        /// <example>1020</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeWindow" /> class.
        /// </summary>
        /// <param name="start">
        /// Start time in minutes since local midnight.<br/>
        /// Example: 540
        /// </param>
        /// <param name="end">
        /// End time in minutes since local midnight.<br/>
        /// Example: 1020
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeWindow(
            double start,
            double end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeWindow" /> class.
        /// </summary>
        public TimeWindow()
        {
        }
    }
}