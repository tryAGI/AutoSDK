//HintName: G.Models.ProtectedBranchRequiredStatusCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Protected Branch Required Status Check
    /// </summary>
    public sealed partial class ProtectedBranchRequiredStatusCheck
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enforcement_level")]
        public string? EnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contexts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Contexts { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("checks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ProtectedBranchRequiredStatusCheckCheck> Checks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contexts_url")]
        public string? ContextsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredStatusCheck" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="enforcementLevel"></param>
        /// <param name="contexts"></param>
        /// <param name="checks"></param>
        /// <param name="contextsUrl"></param>
        /// <param name="strict"></param>
        public ProtectedBranchRequiredStatusCheck(
            global::System.Collections.Generic.IList<string> contexts,
            global::System.Collections.Generic.IList<global::G.ProtectedBranchRequiredStatusCheckCheck> checks,
            string? url,
            string? enforcementLevel,
            string? contextsUrl,
            bool? strict)
        {
            this.Contexts = contexts ?? throw new global::System.ArgumentNullException(nameof(contexts));
            this.Checks = checks ?? throw new global::System.ArgumentNullException(nameof(checks));
            this.Url = url;
            this.EnforcementLevel = enforcementLevel;
            this.ContextsUrl = contextsUrl;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProtectedBranchRequiredStatusCheck" /> class.
        /// </summary>
        public ProtectedBranchRequiredStatusCheck()
        {
        }
    }
}