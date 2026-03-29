//HintName: G.Models.NvidiaHardwareOption.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NvidiaHardwareOption
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pricing", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.NvidiaServerlessPricing Pricing { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("specs")]
        public global::System.Collections.Generic.Dictionary<string, string>? Specs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NvidiaHardwareOption" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="pricing"></param>
        /// <param name="specs"></param>
        public NvidiaHardwareOption(
            string id,
            string name,
            string type,
            global::G.NvidiaServerlessPricing pricing,
            global::System.Collections.Generic.Dictionary<string, string>? specs)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Pricing = pricing ?? throw new global::System.ArgumentNullException(nameof(pricing));
            this.Specs = specs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NvidiaHardwareOption" /> class.
        /// </summary>
        public NvidiaHardwareOption()
        {
        }
    }
}