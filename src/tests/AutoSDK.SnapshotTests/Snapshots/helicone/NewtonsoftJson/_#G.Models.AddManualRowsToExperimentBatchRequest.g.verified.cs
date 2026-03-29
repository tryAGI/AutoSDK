//HintName: G.Models.AddManualRowsToExperimentBatchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddManualRowsToExperimentBatchRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputs", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> Inputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddManualRowsToExperimentBatchRequest" /> class.
        /// </summary>
        /// <param name="inputs"></param>
        public AddManualRowsToExperimentBatchRequest(
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> inputs)
        {
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddManualRowsToExperimentBatchRequest" /> class.
        /// </summary>
        public AddManualRowsToExperimentBatchRequest()
        {
        }
    }
}