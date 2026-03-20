//HintName: G.Models.GatewayTimeoutErrorBody28.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GatewayTimeoutErrorBody28
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
        /// Initializes a new instance of the <see cref="GatewayTimeoutErrorBody28" /> class.
        /// </summary>
        /// <param name="data"></param>
        public GatewayTimeoutErrorBody28(
            string? data)
        {
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayTimeoutErrorBody28" /> class.
        /// </summary>
        public GatewayTimeoutErrorBody28()
        {
        }
    }
}