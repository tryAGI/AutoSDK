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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VoiceCostTypeJsonConverter))]
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
        [global::System.Text.Json.Serialization.JsonPropertyName("voice")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Voice { get; set; }

        /// <summary>
        /// This is the number of characters that were generated during the call. These should be total characters used in the call for single assistant calls, while squad calls will have multiple voice costs one for each assistant that was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("characters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Characters { get; set; }

        /// <summary>
        /// This is the cost of the component in USD.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Cost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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