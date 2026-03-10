//HintName: G.Models.BulkExportUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"Cancelled"</default>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; } = "Cancelled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportUpdate" /> class.
        /// </summary>
        /// <param name="status"></param>
        public BulkExportUpdate(
            string status = "Cancelled")
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportUpdate" /> class.
        /// </summary>
        public BulkExportUpdate()
        {
        }
    }
}