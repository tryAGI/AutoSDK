//HintName: G.Models.WordTimestamps.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WordTimestamps
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("words", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Words { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("start", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> Start { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("end", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<double> End { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WordTimestamps" /> class.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public WordTimestamps(
            global::System.Collections.Generic.IList<string> words,
            global::System.Collections.Generic.IList<double> start,
            global::System.Collections.Generic.IList<double> end)
        {
            this.Words = words ?? throw new global::System.ArgumentNullException(nameof(words));
            this.Start = start ?? throw new global::System.ArgumentNullException(nameof(start));
            this.End = end ?? throw new global::System.ArgumentNullException(nameof(end));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordTimestamps" /> class.
        /// </summary>
        public WordTimestamps()
        {
        }
    }
}