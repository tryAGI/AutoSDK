//HintName: G.Models.IssuesSetLabelsRequestVariant3Label.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IssuesSetLabelsRequestVariant3Label
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
        /// Initializes a new instance of the <see cref="IssuesSetLabelsRequestVariant3Label" /> class.
        /// </summary>
        /// <param name="name"></param>
        public IssuesSetLabelsRequestVariant3Label(
            string name)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesSetLabelsRequestVariant3Label" /> class.
        /// </summary>
        public IssuesSetLabelsRequestVariant3Label()
        {
        }
    }
}