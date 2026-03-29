//HintName: G.Models.HttpapiGenericRespCustomerCreateIndexResp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HttpapiGenericRespCustomerCreateIndexResp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public int? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::G.CustomerCreateIndexResp? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpapiGenericRespCustomerCreateIndexResp" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="data"></param>
        public HttpapiGenericRespCustomerCreateIndexResp(
            int? code,
            global::G.CustomerCreateIndexResp? data)
        {
            this.Code = code;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpapiGenericRespCustomerCreateIndexResp" /> class.
        /// </summary>
        public HttpapiGenericRespCustomerCreateIndexResp()
        {
        }
    }
}