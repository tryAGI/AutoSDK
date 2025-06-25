//HintName: G.Models.PagesHealthCheckAltDomain.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PagesHealthCheckAltDomain
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        public string? Host { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nameservers")]
        public string? Nameservers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dns_resolves")]
        public bool? DnsResolves { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_proxied")]
        public bool? IsProxied { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_cloudflare_ip")]
        public bool? IsCloudflareIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_fastly_ip")]
        public bool? IsFastlyIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_old_ip_address")]
        public bool? IsOldIpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_a_record")]
        public bool? IsARecord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_cname_record")]
        public bool? HasCnameRecord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_mx_records_present")]
        public bool? HasMxRecordsPresent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_valid_domain")]
        public bool? IsValidDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_apex_domain")]
        public bool? IsApexDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("should_be_a_record")]
        public bool? ShouldBeARecord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_cname_to_github_user_domain")]
        public bool? IsCnameToGithubUserDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_cname_to_pages_dot_github_dot_com")]
        public bool? IsCnameToPagesDotGithubDotCom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_cname_to_fastly")]
        public bool? IsCnameToFastly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_pointed_to_github_pages_ip")]
        public bool? IsPointedToGithubPagesIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_non_github_pages_ip_present")]
        public bool? IsNonGithubPagesIpPresent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_pages_domain")]
        public bool? IsPagesDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_served_by_pages")]
        public bool? IsServedByPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_valid")]
        public bool? IsValid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("responds_to_https")]
        public bool? RespondsToHttps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforces_https")]
        public bool? EnforcesHttps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("https_error")]
        public string? HttpsError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_https_eligible")]
        public bool? IsHttpsEligible { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caa_error")]
        public string? CaaError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesHealthCheckAltDomain" /> class.
        /// </summary>
        /// <param name="host"></param>
        /// <param name="uri"></param>
        /// <param name="nameservers"></param>
        /// <param name="dnsResolves"></param>
        /// <param name="isProxied"></param>
        /// <param name="isCloudflareIp"></param>
        /// <param name="isFastlyIp"></param>
        /// <param name="isOldIpAddress"></param>
        /// <param name="isARecord"></param>
        /// <param name="hasCnameRecord"></param>
        /// <param name="hasMxRecordsPresent"></param>
        /// <param name="isValidDomain"></param>
        /// <param name="isApexDomain"></param>
        /// <param name="shouldBeARecord"></param>
        /// <param name="isCnameToGithubUserDomain"></param>
        /// <param name="isCnameToPagesDotGithubDotCom"></param>
        /// <param name="isCnameToFastly"></param>
        /// <param name="isPointedToGithubPagesIp"></param>
        /// <param name="isNonGithubPagesIpPresent"></param>
        /// <param name="isPagesDomain"></param>
        /// <param name="isServedByPages"></param>
        /// <param name="isValid"></param>
        /// <param name="reason"></param>
        /// <param name="respondsToHttps"></param>
        /// <param name="enforcesHttps"></param>
        /// <param name="httpsError"></param>
        /// <param name="isHttpsEligible"></param>
        /// <param name="caaError"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PagesHealthCheckAltDomain(
            string? host,
            string? uri,
            string? nameservers,
            bool? dnsResolves,
            bool? isProxied,
            bool? isCloudflareIp,
            bool? isFastlyIp,
            bool? isOldIpAddress,
            bool? isARecord,
            bool? hasCnameRecord,
            bool? hasMxRecordsPresent,
            bool? isValidDomain,
            bool? isApexDomain,
            bool? shouldBeARecord,
            bool? isCnameToGithubUserDomain,
            bool? isCnameToPagesDotGithubDotCom,
            bool? isCnameToFastly,
            bool? isPointedToGithubPagesIp,
            bool? isNonGithubPagesIpPresent,
            bool? isPagesDomain,
            bool? isServedByPages,
            bool? isValid,
            string? reason,
            bool? respondsToHttps,
            bool? enforcesHttps,
            string? httpsError,
            bool? isHttpsEligible,
            string? caaError)
        {
            this.Host = host;
            this.Uri = uri;
            this.Nameservers = nameservers;
            this.DnsResolves = dnsResolves;
            this.IsProxied = isProxied;
            this.IsCloudflareIp = isCloudflareIp;
            this.IsFastlyIp = isFastlyIp;
            this.IsOldIpAddress = isOldIpAddress;
            this.IsARecord = isARecord;
            this.HasCnameRecord = hasCnameRecord;
            this.HasMxRecordsPresent = hasMxRecordsPresent;
            this.IsValidDomain = isValidDomain;
            this.IsApexDomain = isApexDomain;
            this.ShouldBeARecord = shouldBeARecord;
            this.IsCnameToGithubUserDomain = isCnameToGithubUserDomain;
            this.IsCnameToPagesDotGithubDotCom = isCnameToPagesDotGithubDotCom;
            this.IsCnameToFastly = isCnameToFastly;
            this.IsPointedToGithubPagesIp = isPointedToGithubPagesIp;
            this.IsNonGithubPagesIpPresent = isNonGithubPagesIpPresent;
            this.IsPagesDomain = isPagesDomain;
            this.IsServedByPages = isServedByPages;
            this.IsValid = isValid;
            this.Reason = reason;
            this.RespondsToHttps = respondsToHttps;
            this.EnforcesHttps = enforcesHttps;
            this.HttpsError = httpsError;
            this.IsHttpsEligible = isHttpsEligible;
            this.CaaError = caaError;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagesHealthCheckAltDomain" /> class.
        /// </summary>
        public PagesHealthCheckAltDomain()
        {
        }
    }
}