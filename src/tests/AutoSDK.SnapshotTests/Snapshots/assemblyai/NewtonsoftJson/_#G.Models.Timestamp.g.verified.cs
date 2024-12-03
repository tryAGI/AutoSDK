//HintName: G.Models.Timestamp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Timestamp containing a start and end property in milliseconds
    /// </summary>
    public sealed partial class Timestamp
    {
        /// <summary>
        /// The start time in milliseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public int Start { get; set; } = default!;

        /// <summary>
        /// The end time in milliseconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public int End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Timestamp" /> class.
        /// </summary>
        /// <param name="start">
        /// The start time in milliseconds
        /// </param>
        /// <param name="end">
        /// The end time in milliseconds
        /// </param>
        public Timestamp(
            int start,
            int end)
        {
            this.Start = start;
            this.End = end;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Timestamp" /> class.
        /// </summary>
        public Timestamp()
        {
        }
    }
}