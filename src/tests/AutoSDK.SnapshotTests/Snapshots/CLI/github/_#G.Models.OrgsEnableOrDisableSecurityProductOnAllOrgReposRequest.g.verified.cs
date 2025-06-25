﻿//HintName: G.Models.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest
    {
        /// <summary>
        /// CodeQL query suite to be used. If you specify the `query_suite` parameter, the default setup will be configured with this query suite only on all repositories that didn't have default setup already configured. It will not change the query suite on repositories that already have default setup configured.<br/>
        /// If you don't specify any `query_suite` in your request, the preferred query suite of the organization will be applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query_suite")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuiteJsonConverter))]
        public global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite? QuerySuite { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest" /> class.
        /// </summary>
        /// <param name="querySuite">
        /// CodeQL query suite to be used. If you specify the `query_suite` parameter, the default setup will be configured with this query suite only on all repositories that didn't have default setup already configured. It will not change the query suite on repositories that already have default setup configured.<br/>
        /// If you don't specify any `query_suite` in your request, the preferred query suite of the organization will be applied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest(
            global::G.OrgsEnableOrDisableSecurityProductOnAllOrgReposRequestQuerySuite? querySuite)
        {
            this.QuerySuite = querySuite;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest" /> class.
        /// </summary>
        public OrgsEnableOrDisableSecurityProductOnAllOrgReposRequest()
        {
        }
    }
}