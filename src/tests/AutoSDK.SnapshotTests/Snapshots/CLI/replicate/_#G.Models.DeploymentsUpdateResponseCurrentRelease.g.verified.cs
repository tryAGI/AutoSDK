﻿//HintName: G.Models.DeploymentsUpdateResponseCurrentRelease.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeploymentsUpdateResponseCurrentRelease
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::G.DeploymentsUpdateResponseCurrentReleaseConfiguration? Configuration { get; set; }

        /// <summary>
        /// The time the release was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public global::G.DeploymentsUpdateResponseCurrentReleaseCreatedBy? CreatedBy { get; set; }

        /// <summary>
        /// The model identifier string in the format of `{model_owner}/{model_name}`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The release number.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// The ID of the model version used in the release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsUpdateResponseCurrentRelease" /> class.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="createdAt">
        /// The time the release was created.
        /// </param>
        /// <param name="createdBy"></param>
        /// <param name="model">
        /// The model identifier string in the format of `{model_owner}/{model_name}`.
        /// </param>
        /// <param name="number">
        /// The release number.
        /// </param>
        /// <param name="version">
        /// The ID of the model version used in the release.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentsUpdateResponseCurrentRelease(
            global::G.DeploymentsUpdateResponseCurrentReleaseConfiguration? configuration,
            global::System.DateTime? createdAt,
            global::G.DeploymentsUpdateResponseCurrentReleaseCreatedBy? createdBy,
            string? model,
            int? number,
            string? version)
        {
            this.Configuration = configuration;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Model = model;
            this.Number = number;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentsUpdateResponseCurrentRelease" /> class.
        /// </summary>
        public DeploymentsUpdateResponseCurrentRelease()
        {
        }
    }
}