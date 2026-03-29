//HintName: G.Models.Formatting.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Formatting.
    /// </summary>
    public sealed partial class Formatting
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bold")]
        public bool? Bold { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("italic")]
        public bool? Italic { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("underline")]
        public bool? Underline { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strikethrough")]
        public bool? Strikethrough { get; set; }

        /// <summary>
        /// Text script position.<br/>
        /// Default Value: baseline
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("script")]
        public global::G.Script? Script { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Formatting" /> class.
        /// </summary>
        /// <param name="bold">
        /// Default Value: false
        /// </param>
        /// <param name="italic">
        /// Default Value: false
        /// </param>
        /// <param name="underline">
        /// Default Value: false
        /// </param>
        /// <param name="strikethrough">
        /// Default Value: false
        /// </param>
        /// <param name="script">
        /// Text script position.<br/>
        /// Default Value: baseline
        /// </param>
        public Formatting(
            bool? bold,
            bool? italic,
            bool? underline,
            bool? strikethrough,
            global::G.Script? script)
        {
            this.Bold = bold;
            this.Italic = italic;
            this.Underline = underline;
            this.Strikethrough = strikethrough;
            this.Script = script;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Formatting" /> class.
        /// </summary>
        public Formatting()
        {
        }
    }
}