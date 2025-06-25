﻿//HintName: G.Models.RepositoryAdvisorySubmission.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Included only in responses
    /// </summary>
    public sealed partial class RepositoryAdvisorySubmission
    {
        /// <summary>
        /// Whether a private vulnerability report was accepted by the repository's administrators.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted")]
        public bool Accepted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisorySubmission" /> class.
        /// </summary>
        /// <param name="accepted">
        /// Whether a private vulnerability report was accepted by the repository's administrators.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryAdvisorySubmission(
            bool accepted = default!)
        {
            this.Accepted = accepted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryAdvisorySubmission" /> class.
        /// </summary>
        public RepositoryAdvisorySubmission()
        {
        }
    }
}