//HintName: G.Models.ResponseDetail.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseDetail
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("logid", Required = global::Newtonsoft.Json.Required.Always)]
        public string Logid { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDetail" /> class.
        /// </summary>
        /// <param name="logid"></param>
        public ResponseDetail(
            string logid)
        {
            this.Logid = logid ?? throw new global::System.ArgumentNullException(nameof(logid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDetail" /> class.
        /// </summary>
        public ResponseDetail()
        {
        }
    }
}