//HintName: G.Models.GetPropertiesOverTimeRequest2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetPropertiesOverTimeRequest2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("propertyKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string PropertyKey { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPropertiesOverTimeRequest2" /> class.
        /// </summary>
        /// <param name="propertyKey"></param>
        public GetPropertiesOverTimeRequest2(
            string propertyKey)
        {
            this.PropertyKey = propertyKey ?? throw new global::System.ArgumentNullException(nameof(propertyKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPropertiesOverTimeRequest2" /> class.
        /// </summary>
        public GetPropertiesOverTimeRequest2()
        {
        }
    }
}