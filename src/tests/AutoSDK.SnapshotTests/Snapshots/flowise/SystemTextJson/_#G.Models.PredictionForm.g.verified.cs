//HintName: G.Models.PredictionForm.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The form object to send to the flow (alternative to question for Agentflow V2)<br/>
    /// Example: {"title":"Example","count":1}
    /// </summary>
    public sealed partial class PredictionForm
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}