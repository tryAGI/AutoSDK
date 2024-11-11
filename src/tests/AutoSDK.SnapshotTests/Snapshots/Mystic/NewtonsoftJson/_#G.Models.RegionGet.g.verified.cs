//HintName: G.Models.RegionGet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Base model for schemas.
    /// </summary>
    public sealed partial class RegionGet
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind", Required = global::Newtonsoft.Json.Required.Always)]
        public string Kind { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self_link", Required = global::Newtonsoft.Json.Required.Always)]
        public string SelfLink { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("zones", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Zones { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionGet" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="kind"></param>
        /// <param name="name"></param>
        /// <param name="selfLink"></param>
        /// <param name="status"></param>
        /// <param name="zones"></param>
        public RegionGet(
            int id,
            string kind,
            string name,
            string selfLink,
            string status,
            global::System.Collections.Generic.IList<string> zones)
        {
            this.Id = id;
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SelfLink = selfLink ?? throw new global::System.ArgumentNullException(nameof(selfLink));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Zones = zones ?? throw new global::System.ArgumentNullException(nameof(zones));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionGet" /> class.
        /// </summary>
        public RegionGet()
        {
        }
    }
}