﻿//HintName: G.Models.CodeSecuritySetConfigurationAsDefaultRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeSecuritySetConfigurationAsDefaultRequest
    {
        /// <summary>
        /// Specify which types of repository this security configuration should be applied to by default.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_for_new_repos")]
        public global::G.CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos? DefaultForNewRepos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecuritySetConfigurationAsDefaultRequest" /> class.
        /// </summary>
        /// <param name="defaultForNewRepos">
        /// Specify which types of repository this security configuration should be applied to by default.
        /// </param>
        public CodeSecuritySetConfigurationAsDefaultRequest(
            global::G.CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos? defaultForNewRepos)
        {
            this.DefaultForNewRepos = defaultForNewRepos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeSecuritySetConfigurationAsDefaultRequest" /> class.
        /// </summary>
        public CodeSecuritySetConfigurationAsDefaultRequest()
        {
        }
    }
}