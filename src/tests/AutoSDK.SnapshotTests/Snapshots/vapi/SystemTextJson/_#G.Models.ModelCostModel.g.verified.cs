//HintName: G.Models.ModelCostModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the model that was used during the call.<br/>
    /// This matches one of the following:<br/>
    /// - `call.assistant.model`,<br/>
    /// - `call.assistantId-&gt;model`,<br/>
    /// - `call.squad[n].assistant.model`,<br/>
    /// - `call.squad[n].assistantId-&gt;model`,<br/>
    /// - `call.squadId-&gt;[n].assistant.model`,<br/>
    /// - `call.squadId-&gt;[n].assistantId-&gt;model`.
    /// </summary>
    public sealed partial class ModelCostModel
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}