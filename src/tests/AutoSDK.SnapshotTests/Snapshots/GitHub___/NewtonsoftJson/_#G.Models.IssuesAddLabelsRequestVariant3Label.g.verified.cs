//HintName: G.Models.IssuesAddLabelsRequestVariant3Label.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesAddLabelsRequestVariant3Label
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddLabelsRequestVariant3Label" /> class.
        /// </summary>
        /// <param name="name"></param>
        public IssuesAddLabelsRequestVariant3Label(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesAddLabelsRequestVariant3Label" /> class.
        /// </summary>
        public IssuesAddLabelsRequestVariant3Label()
        {
        }
    }
}