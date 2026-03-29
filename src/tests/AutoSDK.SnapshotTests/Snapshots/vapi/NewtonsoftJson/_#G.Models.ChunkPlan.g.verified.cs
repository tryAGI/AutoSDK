//HintName: G.Models.ChunkPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChunkPlan
    {
        /// <summary>
        /// This determines whether the model output is chunked before being sent to the voice provider. Default `true`.<br/>
        /// Usage:<br/>
        /// - To rely on the voice provider's audio generation logic, set this to `false`.<br/>
        /// - If seeing issues with quality, set this to `true`.<br/>
        /// If disabled, Vapi-provided audio control tokens like &lt;flush /&gt; will not work.<br/>
        /// @default true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// This is the minimum number of characters in a chunk.<br/>
        /// Usage:<br/>
        /// - To increase quality, set this to a higher value.<br/>
        /// - To decrease latency, set this to a lower value.<br/>
        /// @default 30<br/>
        /// Example: 30
        /// </summary>
        /// <example>30</example>
        [global::Newtonsoft.Json.JsonProperty("minCharacters")]
        public double? MinCharacters { get; set; }

        /// <summary>
        /// These are the punctuations that are considered valid boundaries for a chunk to be created.<br/>
        /// Usage:<br/>
        /// - To increase quality, constrain to fewer boundaries.<br/>
        /// - To decrease latency, enable all.<br/>
        /// Default is automatically set to balance the trade-off between quality and latency based on the provider.<br/>
        /// Example: [cjk-period, cjk-comma, period, exclamation, question, semicolon, arabic-comma, urdu-period, devanagari-danda, devanagari-double-danda, pipe, double-pipe, comma, colon]
        /// </summary>
        /// <example>[cjk-period, cjk-comma, period, exclamation, question, semicolon, arabic-comma, urdu-period, devanagari-danda, devanagari-double-danda, pipe, double-pipe, comma, colon]</example>
        [global::Newtonsoft.Json.JsonProperty("punctuationBoundaries")]
        public global::System.Collections.Generic.IList<global::G.ChunkPlanPunctuationBoundarie>? PunctuationBoundaries { get; set; }

        /// <summary>
        /// This is the plan for formatting the chunk before it is sent to the voice provider.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("formatPlan")]
        public global::G.FormatPlan? FormatPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkPlan" /> class.
        /// </summary>
        /// <param name="enabled">
        /// This determines whether the model output is chunked before being sent to the voice provider. Default `true`.<br/>
        /// Usage:<br/>
        /// - To rely on the voice provider's audio generation logic, set this to `false`.<br/>
        /// - If seeing issues with quality, set this to `true`.<br/>
        /// If disabled, Vapi-provided audio control tokens like &lt;flush /&gt; will not work.<br/>
        /// @default true<br/>
        /// Example: true
        /// </param>
        /// <param name="minCharacters">
        /// This is the minimum number of characters in a chunk.<br/>
        /// Usage:<br/>
        /// - To increase quality, set this to a higher value.<br/>
        /// - To decrease latency, set this to a lower value.<br/>
        /// @default 30<br/>
        /// Example: 30
        /// </param>
        /// <param name="punctuationBoundaries">
        /// These are the punctuations that are considered valid boundaries for a chunk to be created.<br/>
        /// Usage:<br/>
        /// - To increase quality, constrain to fewer boundaries.<br/>
        /// - To decrease latency, enable all.<br/>
        /// Default is automatically set to balance the trade-off between quality and latency based on the provider.<br/>
        /// Example: [cjk-period, cjk-comma, period, exclamation, question, semicolon, arabic-comma, urdu-period, devanagari-danda, devanagari-double-danda, pipe, double-pipe, comma, colon]
        /// </param>
        /// <param name="formatPlan">
        /// This is the plan for formatting the chunk before it is sent to the voice provider.
        /// </param>
        public ChunkPlan(
            bool? enabled,
            double? minCharacters,
            global::System.Collections.Generic.IList<global::G.ChunkPlanPunctuationBoundarie>? punctuationBoundaries,
            global::G.FormatPlan? formatPlan)
        {
            this.Enabled = enabled;
            this.MinCharacters = minCharacters;
            this.PunctuationBoundaries = punctuationBoundaries;
            this.FormatPlan = formatPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkPlan" /> class.
        /// </summary>
        public ChunkPlan()
        {
        }
    }
}