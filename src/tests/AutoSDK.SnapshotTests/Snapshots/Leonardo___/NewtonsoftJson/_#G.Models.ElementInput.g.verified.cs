//HintName: G.Models.ElementInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ElementInput
    {
        /// <summary>
        /// Unique identifier for element. Elements can be found from the List Elements endpoint.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("akUUID")]
        public string? AkUUID { get; set; }

        /// <summary>
        /// Weight for the element
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementInput" /> class.
        /// </summary>
        /// <param name="akUUID">
        /// Unique identifier for element. Elements can be found from the List Elements endpoint.
        /// </param>
        /// <param name="weight">
        /// Weight for the element
        /// </param>
        public ElementInput(
            string? akUUID,
            double? weight)
        {
            this.AkUUID = akUUID;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElementInput" /> class.
        /// </summary>
        public ElementInput()
        {
        }
    }
}