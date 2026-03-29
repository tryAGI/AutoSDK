//HintName: G.Models.VoiceCostVoice.g.cs

#nullable enable

namespace G
{
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
    public sealed partial class VoiceCostVoice
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}