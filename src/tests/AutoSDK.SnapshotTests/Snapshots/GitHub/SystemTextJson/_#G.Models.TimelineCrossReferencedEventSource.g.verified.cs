//HintName: G.Models.TimelineCrossReferencedEventSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimelineCrossReferencedEventSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issue")]
        public global::G.Issue? Issue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCrossReferencedEventSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="issue">
        /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TimelineCrossReferencedEventSource(
            string? type,
            global::G.Issue? issue)
        {
            this.Type = type;
            this.Issue = issue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimelineCrossReferencedEventSource" /> class.
        /// </summary>
        public TimelineCrossReferencedEventSource()
        {
        }
    }
}