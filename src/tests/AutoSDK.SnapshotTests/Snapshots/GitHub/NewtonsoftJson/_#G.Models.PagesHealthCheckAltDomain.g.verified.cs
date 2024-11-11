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
        [global::Newtonsoft.Json.JsonProperty("host")]
        public string? Host { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("nameservers")]
        public string? Nameservers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dns_resolves")]
        public bool? DnsResolves { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_proxied")]
        public bool? IsProxied { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_cloudflare_ip")]
        public bool? IsCloudflareIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_fastly_ip")]
        public bool? IsFastlyIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_old_ip_address")]
        public bool? IsOldIpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_a_record")]
        public bool? IsARecord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_cname_record")]
        public bool? HasCnameRecord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_mx_records_present")]
        public bool? HasMxRecordsPresent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_valid_domain")]
        public bool? IsValidDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_apex_domain")]
        public bool? IsApexDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("should_be_a_record")]
        public bool? ShouldBeARecord { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_cname_to_github_user_domain")]
        public bool? IsCnameToGithubUserDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_cname_to_pages_dot_github_dot_com")]
        public bool? IsCnameToPagesDotGithubDotCom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_cname_to_fastly")]
        public bool? IsCnameToFastly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_pointed_to_github_pages_ip")]
        public bool? IsPointedToGithubPagesIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_non_github_pages_ip_present")]
        public bool? IsNonGithubPagesIpPresent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_pages_domain")]
        public bool? IsPagesDomain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_served_by_pages")]
        public bool? IsServedByPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_valid")]
        public bool? IsValid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("responds_to_https")]
        public bool? RespondsToHttps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforces_https")]
        public bool? EnforcesHttps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("https_error")]
        public string? HttpsError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_https_eligible")]
        public bool? IsHttpsEligible { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("caa_error")]
        public string? CaaError { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.PagesHealthCheckAltDomain? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PagesHealthCheckAltDomain>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.PagesHealthCheckAltDomain?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.PagesHealthCheckAltDomain?>(serializer.Deserialize<global::G.PagesHealthCheckAltDomain>(jsonReader));
        }

    }
}