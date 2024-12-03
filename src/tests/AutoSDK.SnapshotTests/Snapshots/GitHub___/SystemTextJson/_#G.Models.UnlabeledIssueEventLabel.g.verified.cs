//HintName: G.Models.UnlabeledIssueEventLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnlabeledIssueEventLabel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlabeledIssueEventLabel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UnlabeledIssueEventLabel(
            string name,
            string color)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnlabeledIssueEventLabel" /> class.
        /// </summary>
        public UnlabeledIssueEventLabel()
        {
        }
    }
}