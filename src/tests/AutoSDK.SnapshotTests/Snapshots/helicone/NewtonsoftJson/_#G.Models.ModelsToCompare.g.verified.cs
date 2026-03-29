//HintName: G.Models.ModelsToCompare.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsToCompare
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("names", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Names { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent", Required = global::Newtonsoft.Json.Required.Always)]
        public string Parent { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsToCompare" /> class.
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="names"></param>
        /// <param name="parent"></param>
        public ModelsToCompare(
            string provider,
            global::System.Collections.Generic.IList<string> names,
            string parent)
        {
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.Names = names ?? throw new global::System.ArgumentNullException(nameof(names));
            this.Parent = parent ?? throw new global::System.ArgumentNullException(nameof(parent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsToCompare" /> class.
        /// </summary>
        public ModelsToCompare()
        {
        }
    }
}