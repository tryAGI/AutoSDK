//HintName: G.Models.TimeToFirstTokenOverTime.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeToFirstTokenOverTime
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttft")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Ttft { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeToFirstTokenOverTime" /> class.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="ttft"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimeToFirstTokenOverTime(
            global::System.DateTime time,
            double ttft)
        {
            this.Time = time;
            this.Ttft = ttft;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeToFirstTokenOverTime" /> class.
        /// </summary>
        public TimeToFirstTokenOverTime()
        {
        }
    }
}