//HintName: G.Models.Duration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Duration
    {
        /// <summary>
        /// Start time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StartSec { get; set; }

        /// <summary>
        /// End time in seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_sec")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double EndSec { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Duration" /> class.
        /// </summary>
        /// <param name="startSec">
        /// Start time in seconds
        /// </param>
        /// <param name="endSec">
        /// End time in seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Duration(
            double startSec,
            double endSec)
        {
            this.StartSec = startSec;
            this.EndSec = endSec;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Duration" /> class.
        /// </summary>
        public Duration()
        {
        }
    }
}