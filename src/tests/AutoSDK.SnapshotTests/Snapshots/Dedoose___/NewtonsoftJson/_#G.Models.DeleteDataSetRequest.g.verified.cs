//HintName: G.Models.DeleteDataSetRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteDataSetRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataSet", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.DataSetVO DataSet { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDataSetRequest" /> class.
        /// </summary>
        /// <param name="dataSet"></param>
        public DeleteDataSetRequest(
            global::G.DataSetVO dataSet)
        {
            this.DataSet = dataSet ?? throw new global::System.ArgumentNullException(nameof(dataSet));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDataSetRequest" /> class.
        /// </summary>
        public DeleteDataSetRequest()
        {
        }
    }
}