//HintName: G.Models.ModelAlias.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelAlias
    {
        /// <summary>
        /// The alias name.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAlias" /> class.
        /// </summary>
        /// <param name="name">
        /// The alias name.<br/>
        /// Included only in responses
        /// </param>
        public ModelAlias(
            string name = default!)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAlias" /> class.
        /// </summary>
        public ModelAlias()
        {
        }
    }
}