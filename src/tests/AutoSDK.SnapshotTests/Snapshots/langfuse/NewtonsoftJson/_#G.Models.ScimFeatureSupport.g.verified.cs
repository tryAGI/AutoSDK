//HintName: G.Models.ScimFeatureSupport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScimFeatureSupport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supported", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Supported { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimFeatureSupport" /> class.
        /// </summary>
        /// <param name="supported"></param>
        public ScimFeatureSupport(
            bool supported)
        {
            this.Supported = supported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimFeatureSupport" /> class.
        /// </summary>
        public ScimFeatureSupport()
        {
        }
    }
}