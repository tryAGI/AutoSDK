//HintName: G.Models.AccountCostsData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccountCostsData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code")]
        public int? Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg")]
        public string? Msg { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource_pack_subscribe_infos")]
        public global::System.Collections.Generic.IList<global::G.ResourcePackage>? ResourcePackSubscribeInfos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCostsData" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="msg"></param>
        /// <param name="resourcePackSubscribeInfos"></param>
        public AccountCostsData(
            int? code,
            string? msg,
            global::System.Collections.Generic.IList<global::G.ResourcePackage>? resourcePackSubscribeInfos)
        {
            this.Code = code;
            this.Msg = msg;
            this.ResourcePackSubscribeInfos = resourcePackSubscribeInfos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountCostsData" /> class.
        /// </summary>
        public AccountCostsData()
        {
        }
    }
}