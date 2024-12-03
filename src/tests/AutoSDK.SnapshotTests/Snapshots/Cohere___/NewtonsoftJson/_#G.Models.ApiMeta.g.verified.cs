//HintName: G.Models.ApiMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_version")]
        public global::G.ApiMetaApiVersion? ApiVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billed_units")]
        public global::G.ApiMetaBilledUnits? BilledUnits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokens")]
        public global::G.ApiMetaTokens? Tokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warnings")]
        public global::System.Collections.Generic.IList<string>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMeta" /> class.
        /// </summary>
        /// <param name="apiVersion"></param>
        /// <param name="billedUnits"></param>
        /// <param name="tokens"></param>
        /// <param name="warnings"></param>
        public ApiMeta(
            global::G.ApiMetaApiVersion? apiVersion,
            global::G.ApiMetaBilledUnits? billedUnits,
            global::G.ApiMetaTokens? tokens,
            global::System.Collections.Generic.IList<string>? warnings)
        {
            this.ApiVersion = apiVersion;
            this.BilledUnits = billedUnits;
            this.Tokens = tokens;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiMeta" /> class.
        /// </summary>
        public ApiMeta()
        {
        }
    }
}