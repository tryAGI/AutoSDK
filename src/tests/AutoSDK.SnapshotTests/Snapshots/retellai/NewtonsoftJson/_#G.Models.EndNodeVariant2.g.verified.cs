//HintName: G.Models.EndNodeVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndNodeVariant2
    {
        /// <summary>
        /// Type of the node
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EndNodeVariant2TypeJsonConverter))]
        public global::G.EndNodeVariant2Type Type { get; set; }

        /// <summary>
        /// If true, will speak during execution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("speak_during_execution")]
        public bool? SpeakDuringExecution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instruction")]
        public global::G.NodeInstruction? Instruction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EndNodeVariant2" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of the node
        /// </param>
        /// <param name="speakDuringExecution">
        /// If true, will speak during execution
        /// </param>
        /// <param name="instruction"></param>
        public EndNodeVariant2(
            global::G.EndNodeVariant2Type type,
            bool? speakDuringExecution,
            global::G.NodeInstruction? instruction)
        {
            this.Type = type;
            this.SpeakDuringExecution = speakDuringExecution;
            this.Instruction = instruction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndNodeVariant2" /> class.
        /// </summary>
        public EndNodeVariant2()
        {
        }
    }
}