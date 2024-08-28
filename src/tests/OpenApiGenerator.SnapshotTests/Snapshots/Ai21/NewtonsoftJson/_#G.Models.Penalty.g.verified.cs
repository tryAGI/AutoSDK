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
        public bool ApplyToWhitespaces { get; set; } = true;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("applyToPunctuations")]
        public bool ApplyToPunctuations { get; set; } = true;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("applyToNumbers")]
        public bool ApplyToNumbers { get; set; } = true;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("applyToStopwords")]
        public bool ApplyToStopwords { get; set; } = true;

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("applyToEmojis")]
        public bool ApplyToEmojis { get; set; } = true;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}