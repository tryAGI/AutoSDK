//HintName: G.Models.Penalty.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Penalty
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scale", Required = global::Newtonsoft.Json.Required.Always)]
        public double Scale { get; set; } = default!;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("applyToWhitespaces")]
        public bool? ApplyToWhitespaces { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("applyToPunctuations")]
        public bool? ApplyToPunctuations { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("applyToNumbers")]
        public bool? ApplyToNumbers { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("applyToStopwords")]
        public bool? ApplyToStopwords { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("applyToEmojis")]
        public bool? ApplyToEmojis { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Penalty" /> class.
        /// </summary>
        /// <param name="scale"></param>
        /// <param name="applyToWhitespaces">
        /// Default Value: true
        /// </param>
        /// <param name="applyToPunctuations">
        /// Default Value: true
        /// </param>
        /// <param name="applyToNumbers">
        /// Default Value: true
        /// </param>
        /// <param name="applyToStopwords">
        /// Default Value: true
        /// </param>
        /// <param name="applyToEmojis">
        /// Default Value: true
        /// </param>
        public Penalty(
            double scale,
            bool? applyToWhitespaces,
            bool? applyToPunctuations,
            bool? applyToNumbers,
            bool? applyToStopwords,
            bool? applyToEmojis)
        {
            this.Scale = scale;
            this.ApplyToWhitespaces = applyToWhitespaces;
            this.ApplyToPunctuations = applyToPunctuations;
            this.ApplyToNumbers = applyToNumbers;
            this.ApplyToStopwords = applyToStopwords;
            this.ApplyToEmojis = applyToEmojis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Penalty" /> class.
        /// </summary>
        public Penalty()
        {
        }
    }
}