//HintName: G.Models.IssuesAddLabelsRequestVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesAddLabelsRequestVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.IList<global::G.IssuesAddLabelsRequestVariant3Label>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddLabelsRequestVariant3" /> class.
        /// </summary>
        /// <param name="labels"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public IssuesAddLabelsRequestVariant3(
            global::System.Collections.Generic.IList<global::G.IssuesAddLabelsRequestVariant3Label>? labels)
        {
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddLabelsRequestVariant3" /> class.
        /// </summary>
        public IssuesAddLabelsRequestVariant3()
        {
        }
    }
}