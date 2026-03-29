//HintName: G.Models.TimeFilterMs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeFilterMs
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimeUnixMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartTimeUnixMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTimeUnixMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndTimeUnixMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeFilterMs" /> class.
        /// </summary>
        /// <param name="startTimeUnixMs"></param>
        /// <param name="endTimeUnixMs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeFilterMs(
            double startTimeUnixMs,
            double endTimeUnixMs)
        {
            this.StartTimeUnixMs = startTimeUnixMs;
            this.EndTimeUnixMs = endTimeUnixMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeFilterMs" /> class.
        /// </summary>
        public TimeFilterMs()
        {
        }
    }
}