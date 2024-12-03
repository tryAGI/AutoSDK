//HintName: G.Models.BranchProtectionRequiredSignatures.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BranchProtectionRequiredSignatures
    {
        /// <summary>
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/required_signatures
        /// </summary>
        /// <example>https://api.github.com/repos/octocat/Hello-World/branches/master/protection/required_signatures</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtectionRequiredSignatures" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/octocat/Hello-World/branches/master/protection/required_signatures
        /// </param>
        /// <param name="enabled">
        /// Example: true
        /// </param>
        public BranchProtectionRequiredSignatures(
            string url,
            bool enabled)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BranchProtectionRequiredSignatures" /> class.
        /// </summary>
        public BranchProtectionRequiredSignatures()
        {
        }
    }
}