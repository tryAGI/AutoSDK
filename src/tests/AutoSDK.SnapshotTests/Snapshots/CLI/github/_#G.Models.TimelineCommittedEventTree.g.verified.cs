﻿//HintName: G.Models.TimelineCommittedEventTree.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimelineCommittedEventTree
    {
        /// <summary>
        /// SHA for the commit<br/>
        /// Example: 7638417db6d59f3c431d3e1f261cc637155684cd
        /// </summary>
        /// <example>7638417db6d59f3c431d3e1f261cc637155684cd</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommittedEventTree" /> class.
        /// </summary>
        /// <param name="sha">
        /// SHA for the commit<br/>
        /// Example: 7638417db6d59f3c431d3e1f261cc637155684cd
        /// </param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TimelineCommittedEventTree(
            string sha,
            string url)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCommittedEventTree" /> class.
        /// </summary>
        public TimelineCommittedEventTree()
        {
        }
    }
}