//HintName: G.Models.CommunityProfileFiles.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommunityProfileFiles
    {
        /// <summary>
        /// Code of Conduct Simple
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_of_conduct", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableCodeOfConductSimple? CodeOfConduct { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_of_conduct_file", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableCommunityHealthFile? CodeOfConductFile { get; set; } = default!;

        /// <summary>
        /// License Simple
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableLicenseSimple? License { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("contributing", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableCommunityHealthFile? Contributing { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("readme", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableCommunityHealthFile? Readme { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("issue_template", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableCommunityHealthFile? IssueTemplate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pull_request_template", Required = global::Newtonsoft.Json.Required.Always)]
        public NullableCommunityHealthFile? PullRequestTemplate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}