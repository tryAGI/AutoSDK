//HintName: G.Models.SmsNodeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SmsNodeVariant2TypeJsonConverter))]
        public global::G.SmsNodeVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instruction", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NodeInstruction Instruction { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success_edge", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SmsSuccessEdge SuccessEdge { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_edge", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SmsFailedEdge FailedEdge { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsNodeVariant2" /> class.
        /// </summary>
        /// <param name="instruction"></param>
        /// <param name="successEdge"></param>
        /// <param name="failedEdge"></param>
        /// <param name="type">
        /// Type of the node
        /// </param>
        public SmsNodeVariant2(
            global::G.NodeInstruction instruction,
            global::G.SmsSuccessEdge successEdge,
            global::G.SmsFailedEdge failedEdge,
            global::G.SmsNodeVariant2Type type)
        {
            this.Type = type;
            this.Instruction = instruction;
            this.SuccessEdge = successEdge;
            this.FailedEdge = failedEdge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsNodeVariant2" /> class.
        /// </summary>
        public SmsNodeVariant2()
        {
        }
    }
}