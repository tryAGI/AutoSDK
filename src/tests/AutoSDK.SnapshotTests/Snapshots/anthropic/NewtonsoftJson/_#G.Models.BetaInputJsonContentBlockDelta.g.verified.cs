//HintName: G.Models.BetaInputJsonContentBlockDelta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaInputJsonContentBlockDelta
    {
        /// <summary>
        /// Default Value: input_json_delta
        /// </summary>
        /// <default>global::G.BetaInputJsonContentBlockDeltaType.InputJsonDelta</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.BetaInputJsonContentBlockDeltaTypeJsonConverter))]
        public global::G.BetaInputJsonContentBlockDeltaType Type { get; set; } = global::G.BetaInputJsonContentBlockDeltaType.InputJsonDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partial_json", Required = global::Newtonsoft.Json.Required.Always)]
        public string PartialJson { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputJsonContentBlockDelta" /> class.
        /// </summary>
        /// <param name="partialJson"></param>
        /// <param name="type">
        /// Default Value: input_json_delta
        /// </param>
        public BetaInputJsonContentBlockDelta(
            string partialJson,
            global::G.BetaInputJsonContentBlockDeltaType type = global::G.BetaInputJsonContentBlockDeltaType.InputJsonDelta)
        {
            this.Type = type;
            this.PartialJson = partialJson ?? throw new global::System.ArgumentNullException(nameof(partialJson));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputJsonContentBlockDelta" /> class.
        /// </summary>
        public BetaInputJsonContentBlockDelta()
        {
        }
    }
}