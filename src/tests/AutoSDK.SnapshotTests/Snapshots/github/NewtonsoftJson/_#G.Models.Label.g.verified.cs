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
        /// Example: 208045946
        /// </summary>
        /// <example>208045946</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// Example: MDU6TGFiZWwyMDgwNDU5NDY=
        /// </summary>
        /// <example>MDU6TGFiZWwyMDgwNDU5NDY=</example>
        [global::Newtonsoft.Json.JsonProperty("node_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string NodeId { get; set; } = default!;

        /// <summary>
        /// URL for the label<br/>
        /// Example: https://api.github.com/repositories/42/labels/bug
        /// </summary>
        /// <example>https://api.github.com/repositories/42/labels/bug</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// The name of the label.<br/>
        /// Example: bug
        /// </summary>
        /// <example>bug</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Optional description of the label, such as its purpose.<br/>
        /// Example: Something isn't working
        /// </summary>
        /// <example>Something isn't working</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Description { get; set; } = default!;

        /// <summary>
        /// 6-character hex code, without the leading #, identifying the color<br/>
        /// Example: FFFFFF
        /// </summary>
        /// <example>FFFFFF</example>
        [global::Newtonsoft.Json.JsonProperty("color", Required = global::Newtonsoft.Json.Required.Always)]
        public string Color { get; set; } = default!;

        /// <summary>
        /// Whether this label comes by default in a new repository.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("default", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Default { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the label.<br/>
        /// Example: 208045946
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