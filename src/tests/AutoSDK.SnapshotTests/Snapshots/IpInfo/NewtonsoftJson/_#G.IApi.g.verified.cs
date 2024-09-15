//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// [https://ipinfo.io](https://ipinfo.io).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://ipinfo.io/";

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// General API.
        /// </summary>
        public GeneralClient General { get; }

        /// <summary>
        /// Single info API.
        /// </summary>
        public SingleClient Single { get; }

        /// <summary>
        /// Privacy Detection API.
        /// </summary>
        public PrivacyDetectionClient PrivacyDetection { get; }

        /// <summary>
        /// ASN API.
        /// </summary>
        public AsnClient Asn { get; }

        /// <summary>
        /// IP Ranges API.
        /// </summary>
        public RangesClient Ranges { get; }

        /// <summary>
        /// Hosted Domains API.
        /// </summary>
        public DomainsClient Domains { get; }

        /// <summary>
        /// Abuse Contact API.
        /// </summary>
        public AbuseClient Abuse { get; }

    }
}