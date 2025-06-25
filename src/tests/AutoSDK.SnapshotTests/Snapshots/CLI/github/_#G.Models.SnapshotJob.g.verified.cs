﻿//HintName: G.Models.SnapshotJob.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SnapshotJob
    {
        /// <summary>
        /// The external ID of the job.<br/>
        /// Example: 5622a2b0-63f6-4732-8c34-a1ab27e102a11
        /// </summary>
        /// <example>5622a2b0-63f6-4732-8c34-a1ab27e102a11</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Correlator provides a key that is used to group snapshots submitted over time. Only the "latest" submitted snapshot for a given combination of `job.correlator` and `detector.name` will be considered when calculating a repository's current dependencies. Correlator should be as unique as it takes to distinguish all detection runs for a given "wave" of CI workflow you run. If you're using GitHub Actions, a good default value for this could be the environment variables GITHUB_WORKFLOW and GITHUB_JOB concatenated together. If you're using a build matrix, then you'll also need to add additional key(s) to distinguish between each submission inside a matrix variation.<br/>
        /// Example: yourworkflowname_yourjobname
        /// </summary>
        /// <example>yourworkflowname_yourjobname</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("correlator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Correlator { get; set; }

        /// <summary>
        /// The url for the job.<br/>
        /// Example: http://example.com/build
        /// </summary>
        /// <example>http://example.com/build</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        public string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotJob" /> class.
        /// </summary>
        /// <param name="id">
        /// The external ID of the job.<br/>
        /// Example: 5622a2b0-63f6-4732-8c34-a1ab27e102a11
        /// </param>
        /// <param name="correlator">
        /// Correlator provides a key that is used to group snapshots submitted over time. Only the "latest" submitted snapshot for a given combination of `job.correlator` and `detector.name` will be considered when calculating a repository's current dependencies. Correlator should be as unique as it takes to distinguish all detection runs for a given "wave" of CI workflow you run. If you're using GitHub Actions, a good default value for this could be the environment variables GITHUB_WORKFLOW and GITHUB_JOB concatenated together. If you're using a build matrix, then you'll also need to add additional key(s) to distinguish between each submission inside a matrix variation.<br/>
        /// Example: yourworkflowname_yourjobname
        /// </param>
        /// <param name="htmlUrl">
        /// The url for the job.<br/>
        /// Example: http://example.com/build
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SnapshotJob(
            string id,
            string correlator,
            string? htmlUrl)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Correlator = correlator ?? throw new global::System.ArgumentNullException(nameof(correlator));
            this.HtmlUrl = htmlUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotJob" /> class.
        /// </summary>
        public SnapshotJob()
        {
        }
    }
}