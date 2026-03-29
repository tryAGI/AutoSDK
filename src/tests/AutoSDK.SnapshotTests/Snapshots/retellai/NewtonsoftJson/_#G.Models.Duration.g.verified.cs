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
        [global::Newtonsoft.Json.JsonProperty("start_sec", Required = global::Newtonsoft.Json.Required.Always)]
        public double StartSec { get; set; } = default!;

        /// <summary>
        /// End time in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end_sec", Required = global::Newtonsoft.Json.Required.Always)]
        public double EndSec { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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