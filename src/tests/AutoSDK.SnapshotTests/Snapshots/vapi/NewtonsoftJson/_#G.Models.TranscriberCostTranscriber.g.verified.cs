//HintName: G.Models.TranscriberCostTranscriber.g.cs

#nullable enable

namespace G
{
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
    public sealed partial class TranscriberCostTranscriber
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}