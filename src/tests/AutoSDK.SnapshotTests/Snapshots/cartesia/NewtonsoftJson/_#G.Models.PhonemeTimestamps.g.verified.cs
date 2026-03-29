//HintName: G.Models.PhonemeTimestamps.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhonemeTimestamps
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("phonemes", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Phonemes { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="PhonemeTimestamps" /> class.
        /// </summary>
        /// <param name="phonemes"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public PhonemeTimestamps(
            global::System.Collections.Generic.IList<string> phonemes,
            global::System.Collections.Generic.IList<double> start,
            global::System.Collections.Generic.IList<double> end)
        {
            this.Phonemes = phonemes ?? throw new global::System.ArgumentNullException(nameof(phonemes));
            this.Start = start ?? throw new global::System.ArgumentNullException(nameof(start));
            this.End = end ?? throw new global::System.ArgumentNullException(nameof(end));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhonemeTimestamps" /> class.
        /// </summary>
        public PhonemeTimestamps()
        {
        }
    }
}