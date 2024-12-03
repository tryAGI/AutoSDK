//HintName: G.Models.DeleteConnectorResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteConnectorResponse3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteConnectorResponse3" /> class.
        /// </summary>
        /// <param name="data"></param>
        public DeleteConnectorResponse3(
            string? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteConnectorResponse3" /> class.
        /// </summary>
        public DeleteConnectorResponse3()
        {
        }
    }
}