﻿//HintName: G.Models.DeploymentBranchPolicyNamePatternWithType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentBranchPolicyNamePatternWithType
    {
        /// <summary>
        /// The name pattern that branches or tags must match in order to deploy to the environment.
        /// Wildcard characters will not match `/`. For example, to match branches that begin with `release/` and contain an additional single slash, use `release/*/*`.
        /// For more information about pattern matching syntax, see the [Ruby File.fnmatch documentation](https://ruby-doc.org/core-2.5.1/File.html#method-c-fnmatch).
        /// <br/>Example: release/*
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Whether this rule targets a branch or tag
        /// <br/>Example: branch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public DeploymentBranchPolicyNamePatternWithTypeType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}