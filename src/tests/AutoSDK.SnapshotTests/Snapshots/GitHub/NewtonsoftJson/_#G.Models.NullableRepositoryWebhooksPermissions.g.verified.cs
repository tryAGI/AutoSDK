//HintName: G.Models.NullableRepositoryWebhooksPermissions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NullableRepositoryWebhooksPermissions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("admin", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Admin { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Pull { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triage")]
        public bool? Triage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("push", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Push { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maintain")]
        public bool? Maintain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableRepositoryWebhooksPermissions" /> class.
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="pull"></param>
        /// <param name="triage"></param>
        /// <param name="push"></param>
        /// <param name="maintain"></param>
        public NullableRepositoryWebhooksPermissions(
            bool admin,
            bool pull,
            bool push,
            bool? triage,
            bool? maintain)
        {
            this.Admin = admin;
            this.Pull = pull;
            this.Push = push;
            this.Triage = triage;
            this.Maintain = maintain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableRepositoryWebhooksPermissions" /> class.
        /// </summary>
        public NullableRepositoryWebhooksPermissions()
        {
        }
    }
}