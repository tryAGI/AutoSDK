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
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("color")]
        public string? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEventLabel" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="color"></param>
        public IssueEventLabel(
            string? name,
            string? color)
        {
            this.Name = name;
            this.Color = color;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueEventLabel" /> class.
        /// </summary>
        public IssueEventLabel()
        {
        }
    }
}