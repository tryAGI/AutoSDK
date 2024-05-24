//HintName: G.Models.CodeScanningAlertSetState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets the state of the code scanning alert. You must provide `dismissed_reason` when you set the state to `dismissed`.
    /// </summary>
    public sealed partial class CodeScanningAlertSetState
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}