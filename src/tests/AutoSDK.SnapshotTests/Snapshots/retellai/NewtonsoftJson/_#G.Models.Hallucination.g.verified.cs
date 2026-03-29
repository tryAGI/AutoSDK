//HintName: G.Models.Hallucination.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Hallucination
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.HallucinationType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reason { get; set; } = default!;

        /// <summary>
        /// true = minor hallucination, false/undefined = major hallucination (defaults to major for backward compatibility)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("low_severity")]
        public bool? LowSeverity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Hallucination" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="reason"></param>
        /// <param name="lowSeverity">
        /// true = minor hallucination, false/undefined = major hallucination (defaults to major for backward compatibility)
        /// </param>
        public Hallucination(
            global::G.HallucinationType type,
            string reason,
            bool? lowSeverity)
        {
            this.Type = type;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.LowSeverity = lowSeverity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hallucination" /> class.
        /// </summary>
        public Hallucination()
        {
        }
    }
}