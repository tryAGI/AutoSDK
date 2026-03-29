//HintName: G.Models.RunEvalDataDatasetRows.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Dataset rows
    /// </summary>
    public sealed partial class RunEvalDataDatasetRows
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEvalDataDatasetRows" /> class.
        /// </summary>
        /// <param name="data"></param>
        public RunEvalDataDatasetRows(
            global::System.Collections.Generic.IList<object> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunEvalDataDatasetRows" /> class.
        /// </summary>
        public RunEvalDataDatasetRows()
        {
        }
    }
}