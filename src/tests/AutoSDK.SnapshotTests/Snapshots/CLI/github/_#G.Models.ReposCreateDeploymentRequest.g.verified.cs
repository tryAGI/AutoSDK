﻿//HintName: G.Models.ReposCreateDeploymentRequest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReposCreateDeploymentRequest
    {
        /// <summary>
        /// The ref to deploy. This can be a branch, tag, or SHA.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// Specifies a task to execute (e.g., `deploy` or `deploy:migrations`).<br/>
        /// Default Value: deploy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task")]
        public string? Task { get; set; }

        /// <summary>
        /// Attempts to automatically merge the default branch into the requested ref, if it's behind the default branch.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_merge")]
        public bool? AutoMerge { get; set; }

        /// <summary>
        /// The [status](https://docs.github.com/rest/commits/statuses) contexts to verify against commit status checks. If you omit this parameter, GitHub verifies all unique contexts before creating a deployment. To bypass checking entirely, pass an empty array. Defaults to all unique contexts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_contexts")]
        public global::System.Collections.Generic.IList<string>? RequiredContexts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payload")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<object, string>))]
        public global::G.OneOf<object, string>? Payload { get; set; }

        /// <summary>
        /// Name for the target deployment environment (e.g., `production`, `staging`, `qa`).<br/>
        /// Default Value: production
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// Short description of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Specifies if the given environment is specific to the deployment and will no longer exist at some point in the future. Default: `false`<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transient_environment")]
        public bool? TransientEnvironment { get; set; }

        /// <summary>
        /// Specifies if the given environment is one that end-users directly interact with. Default: `true` when `environment` is `production` and `false` otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("production_environment")]
        public bool? ProductionEnvironment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateDeploymentRequest" /> class.
        /// </summary>
        /// <param name="ref">
        /// The ref to deploy. This can be a branch, tag, or SHA.
        /// </param>
        /// <param name="task">
        /// Specifies a task to execute (e.g., `deploy` or `deploy:migrations`).<br/>
        /// Default Value: deploy
        /// </param>
        /// <param name="autoMerge">
        /// Attempts to automatically merge the default branch into the requested ref, if it's behind the default branch.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="requiredContexts">
        /// The [status](https://docs.github.com/rest/commits/statuses) contexts to verify against commit status checks. If you omit this parameter, GitHub verifies all unique contexts before creating a deployment. To bypass checking entirely, pass an empty array. Defaults to all unique contexts.
        /// </param>
        /// <param name="payload"></param>
        /// <param name="environment">
        /// Name for the target deployment environment (e.g., `production`, `staging`, `qa`).<br/>
        /// Default Value: production
        /// </param>
        /// <param name="description">
        /// Short description of the deployment.
        /// </param>
        /// <param name="transientEnvironment">
        /// Specifies if the given environment is specific to the deployment and will no longer exist at some point in the future. Default: `false`<br/>
        /// Default Value: false
        /// </param>
        /// <param name="productionEnvironment">
        /// Specifies if the given environment is one that end-users directly interact with. Default: `true` when `environment` is `production` and `false` otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReposCreateDeploymentRequest(
            string @ref,
            string? task,
            bool? autoMerge,
            global::System.Collections.Generic.IList<string>? requiredContexts,
            global::G.OneOf<object, string>? payload,
            string? environment,
            string? description,
            bool? transientEnvironment,
            bool? productionEnvironment)
        {
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Task = task;
            this.AutoMerge = autoMerge;
            this.RequiredContexts = requiredContexts;
            this.Payload = payload;
            this.Environment = environment;
            this.Description = description;
            this.TransientEnvironment = transientEnvironment;
            this.ProductionEnvironment = productionEnvironment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReposCreateDeploymentRequest" /> class.
        /// </summary>
        public ReposCreateDeploymentRequest()
        {
        }
    }
}