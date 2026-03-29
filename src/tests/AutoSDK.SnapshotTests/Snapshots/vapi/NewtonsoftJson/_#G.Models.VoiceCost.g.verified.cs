//HintName: G.Models.VoiceCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceCost
    {
        /// <summary>
        /// This is the type of cost, always 'voice' for this class.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.VoiceCostType Type { get; set; }

        /// <summary>
        /// This is the voice that was used during the call.<br/>
        /// This matches one of the following:<br/>
        /// - `call.assistant.voice`,<br/>
        /// - `call.assistantId-&gt;voice`,<br/>
        /// - `call.squad[n].assistant.voice`,<br/>
        /// - `call.squad[n].assistantId-&gt;voice`,<br/>
        /// - `call.squadId-&gt;[n].assistant.voice`,<br/>
        /// - `call.squadId-&gt;[n].assistantId-&gt;voice`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice", Required = global::Newtonsoft.Json.Required.Always)]
        public object Voice { get; set; } = default!;

        /// <summary>
        /// This is the number of characters that were generated during the call. These should be total characters used in the call for single assistant calls, while squad calls will have multiple voice costs one for each assistant that was used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("characters", Required = global::Newtonsoft.Json.Required.Always)]
        public double Characters { get; set; } = default!;

        /// <summary>
        /// This is the cost of the component in USD.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCost" /> class.
        /// </summary>
        /// <param name="voice">
        /// This is the voice that was used during the call.<br/>
        /// This matches one of the following:<br/>
        /// - `call.assistant.voice`,<br/>
        /// - `call.assistantId-&gt;voice`,<br/>
        /// - `call.squad[n].assistant.voice`,<br/>
        /// - `call.squad[n].assistantId-&gt;voice`,<br/>
        /// - `call.squadId-&gt;[n].assistant.voice`,<br/>
        /// - `call.squadId-&gt;[n].assistantId-&gt;voice`.
        /// </param>
        /// <param name="characters">
        /// This is the number of characters that were generated during the call. These should be total characters used in the call for single assistant calls, while squad calls will have multiple voice costs one for each assistant that was used.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the component in USD.
        /// </param>
        /// <param name="type">
        /// This is the type of cost, always 'voice' for this class.
        /// </param>
        public VoiceCost(
            object voice,
            double characters,
            double cost,
            global::G.VoiceCostType type)
        {
            this.Type = type;
            this.Voice = voice ?? throw new global::System.ArgumentNullException(nameof(voice));
            this.Characters = characters;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceCost" /> class.
        /// </summary>
        public VoiceCost()
        {
        }
    }
}