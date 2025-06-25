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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enforcement_level")]
        public string? EnforcementLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Contexts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ProtectedBranchRequiredStatusCheckCheck> Checks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contexts_url")]
        public string? ContextsUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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