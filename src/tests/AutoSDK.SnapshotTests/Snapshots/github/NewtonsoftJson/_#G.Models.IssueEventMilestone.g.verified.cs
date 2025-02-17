﻿//HintName: G.Models.IssueEventMilestone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Issue Event Milestone
    /// </summary>
    public sealed partial class IssueEventMilestone
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string Title { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEventMilestone" /> class.
        /// </summary>
        /// <param name="title"></param>
        public IssueEventMilestone(
            string title)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEventMilestone" /> class.
        /// </summary>
        public IssueEventMilestone()
        {
        }
    }
}