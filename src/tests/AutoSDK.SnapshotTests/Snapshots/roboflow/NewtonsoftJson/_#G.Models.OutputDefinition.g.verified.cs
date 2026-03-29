//HintName: G.Models.OutputDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutputDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind")]
        public global::System.Collections.Generic.IList<global::G.Kind>? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputDefinition" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        public OutputDefinition(
            string name,
            global::System.Collections.Generic.IList<global::G.Kind>? kind)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutputDefinition" /> class.
        /// </summary>
        public OutputDefinition()
        {
        }
    }
}