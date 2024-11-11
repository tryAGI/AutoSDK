//HintName: G.Models.Label.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Color-coded labels help you categorize and filter your issues (just like labels in Gmail).
    /// </summary>
    public sealed partial class Label
    {
        /// <summary>
        /// Unique identifier for the label.<br/>
        /// Example: 208045946L
        /// </summary>
        /// <example>208045946L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// Example: MDU6TGFiZWwyMDgwNDU5NDY=
        /// </summary>
        /// <example>MDU6TGFiZWwyMDgwNDU5NDY=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// URL for the label<br/>
        /// Example: https://api.github.com/repositories/42/labels/bug
        /// </summary>
        /// <example>https://api.github.com/repositories/42/labels/bug</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The name of the label.<br/>
        /// Example: bug
        /// </summary>
        /// <example>bug</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description of the label, such as its purpose.<br/>
        /// Example: Something isn't working
        /// </summary>
        /// <example>Something isn't working</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// 6-character hex code, without the leading #, identifying the color<br/>
        /// Example: FFFFFF
        /// </summary>
        /// <example>FFFFFF</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("color")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Color { get; set; }

        /// <summary>
        /// Whether this label comes by default in a new repository.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the label.<br/>
        /// Example: 208045946L
        /// </param>
        /// <param name="nodeId">
        /// Example: MDU6TGFiZWwyMDgwNDU5NDY=
        /// </param>
        /// <param name="url">
        /// URL for the label<br/>
        /// Example: https://api.github.com/repositories/42/labels/bug
        /// </param>
        /// <param name="name">
        /// The name of the label.<br/>
        /// Example: bug
        /// </param>
        /// <param name="description">
        /// Optional description of the label, such as its purpose.<br/>
        /// Example: Something isn't working
        /// </param>
        /// <param name="color">
        /// 6-character hex code, without the leading #, identifying the color<br/>
        /// Example: FFFFFF
        /// </param>
        /// <param name="default">
        /// Whether this label comes by default in a new repository.<br/>
        /// Example: true
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Label(
            long id,
            string nodeId,
            string url,
            string name,
            string? description,
            string color,
            bool @default)
        {
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Color = color ?? throw new global::System.ArgumentNullException(nameof(color));
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        public Label()
        {
        }
    }
}