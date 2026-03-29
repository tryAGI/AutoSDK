//HintName: G.Models.HttpapiGenericRespCustomerUpsertResp.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HttpapiGenericRespCustomerUpsertResp
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public int? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::G.HttpapiGenericRespCustomerUpsertRespData? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpapiGenericRespCustomerUpsertResp" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HttpapiGenericRespCustomerUpsertResp(
            int? code,
            global::G.HttpapiGenericRespCustomerUpsertRespData? data)
        {
            this.Code = code;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpapiGenericRespCustomerUpsertResp" /> class.
        /// </summary>
        public HttpapiGenericRespCustomerUpsertResp()
        {
        }
    }
}