//HintName: G.Models.IssueEventLabel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Issue Event Label
    /// </summary>
    public sealed partial class IssueEventLabel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEventLabel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public IssueEventLabel(
            string? name,
            string? color)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEventLabel" /> class.
        /// </summary>
        public IssueEventLabel()
        {
        }
    }
}