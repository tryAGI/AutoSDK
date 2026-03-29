//HintName: G.Models.TranscriberCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranscriberCost
    {
        /// <summary>
        /// This is the type of cost, always 'transcriber' for this class.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TranscriberCostTypeJsonConverter))]
        public global::G.TranscriberCostType Type { get; set; }

        /// <summary>
        /// This is the transcriber that was used during the call.<br/>
        /// This matches one of the below:<br/>
        /// - `call.assistant.transcriber`,<br/>
        /// - `call.assistantId-&gt;transcriber`,<br/>
        /// - `call.squad[n].assistant.transcriber`,<br/>
        /// - `call.squad[n].assistantId-&gt;transcriber`,<br/>
        /// - `call.squadId-&gt;[n].assistant.transcriber`,<br/>
        /// - `call.squadId-&gt;[n].assistantId-&gt;transcriber`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcriber")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Transcriber { get; set; }

        /// <summary>
        /// This is the minutes of `transcriber` usage. This should match `call.endedAt` - `call.startedAt` for single assistant calls, while squad calls will have multiple transcriber costs one for each assistant that was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Minutes { get; set; }

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
        /// Initializes a new instance of the <see cref="TranscriberCost" /> class.
        /// </summary>
        /// <param name="transcriber">
        /// This is the transcriber that was used during the call.<br/>
        /// This matches one of the below:<br/>
        /// - `call.assistant.transcriber`,<br/>
        /// - `call.assistantId-&gt;transcriber`,<br/>
        /// - `call.squad[n].assistant.transcriber`,<br/>
        /// - `call.squad[n].assistantId-&gt;transcriber`,<br/>
        /// - `call.squadId-&gt;[n].assistant.transcriber`,<br/>
        /// - `call.squadId-&gt;[n].assistantId-&gt;transcriber`.
        /// </param>
        /// <param name="minutes">
        /// This is the minutes of `transcriber` usage. This should match `call.endedAt` - `call.startedAt` for single assistant calls, while squad calls will have multiple transcriber costs one for each assistant that was used.
        /// </param>
        /// <param name="cost">
        /// This is the cost of the component in USD.
        /// </param>
        /// <param name="type">
        /// This is the type of cost, always 'transcriber' for this class.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TranscriberCost(
            object transcriber,
            double minutes,
            double cost,
            global::G.TranscriberCostType type)
        {
            this.Type = type;
            this.Transcriber = transcriber ?? throw new global::System.ArgumentNullException(nameof(transcriber));
            this.Minutes = minutes;
            this.Cost = cost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranscriberCost" /> class.
        /// </summary>
        public TranscriberCost()
        {
        }
    }
}