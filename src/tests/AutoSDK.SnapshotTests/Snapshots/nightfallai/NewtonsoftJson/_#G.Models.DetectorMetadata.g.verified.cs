//HintName: G.Models.DetectorMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetectorMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectorMetadata" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="uuid"></param>
        public DetectorMetadata(
            string? name,
            string? uuid)
        {
            this.Name = name;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetectorMetadata" /> class.
        /// </summary>
        public DetectorMetadata()
        {
        }
    }
}