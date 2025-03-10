﻿//HintName: G.Models.RepositoryWebhooksTemplateRepositoryPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryWebhooksTemplateRepositoryPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("admin")]
        public bool? Admin { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maintain")]
        public bool? Maintain { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("push")]
        public bool? Push { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triage")]
        public bool? Triage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull")]
        public bool? Pull { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryWebhooksTemplateRepositoryPermissions" /> class.
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="maintain"></param>
        /// <param name="push"></param>
        /// <param name="triage"></param>
        /// <param name="pull"></param>
        public RepositoryWebhooksTemplateRepositoryPermissions(
            bool? admin,
            bool? maintain,
            bool? push,
            bool? triage,
            bool? pull)
        {
            this.Admin = admin;
            this.Maintain = maintain;
            this.Push = push;
            this.Triage = triage;
            this.Pull = pull;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryWebhooksTemplateRepositoryPermissions" /> class.
        /// </summary>
        public RepositoryWebhooksTemplateRepositoryPermissions()
        {
        }
    }
}