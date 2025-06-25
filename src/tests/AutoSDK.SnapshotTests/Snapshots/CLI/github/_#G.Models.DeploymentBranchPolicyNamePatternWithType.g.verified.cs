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
        /// The name pattern that branches or tags must match in order to deploy to the environment.<br/>
        /// Wildcard characters will not match `/`. For example, to match branches that begin with `release/` and contain an additional single slash, use `release/*/*`.<br/>
        /// For more information about pattern matching syntax, see the [Ruby File.fnmatch documentation](https://ruby-doc.org/core-2.5.1/File.html#method-c-fnmatch).<br/>
        /// Example: release/*
        /// </summary>
        /// <example>release/*</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether this rule targets a branch or tag<br/>
        /// Example: branch
        /// </summary>
        /// <example>branch</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DeploymentBranchPolicyNamePatternWithTypeTypeJsonConverter))]
        public global::G.DeploymentBranchPolicyNamePatternWithTypeType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentBranchPolicyNamePatternWithType" /> class.
        /// </summary>
        /// <param name="name">
        /// The name pattern that branches or tags must match in order to deploy to the environment.<br/>
        /// Wildcard characters will not match `/`. For example, to match branches that begin with `release/` and contain an additional single slash, use `release/*/*`.<br/>
        /// For more information about pattern matching syntax, see the [Ruby File.fnmatch documentation](https://ruby-doc.org/core-2.5.1/File.html#method-c-fnmatch).<br/>
        /// Example: release/*
        /// </param>
        /// <param name="type">
        /// Whether this rule targets a branch or tag<br/>
        /// Example: branch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentBranchPolicyNamePatternWithType(
            string name,
            global::G.DeploymentBranchPolicyNamePatternWithTypeType? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentBranchPolicyNamePatternWithType" /> class.
        /// </summary>
        public DeploymentBranchPolicyNamePatternWithType()
        {
        }
    }
}