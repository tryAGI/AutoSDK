//HintName: G.Models.CropVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CropVariant1
    {
        /// <summary>
        /// The type of the crop.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CropVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CropVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the crop.
        /// </param>
        public CropVariant1(
            global::G.CropVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CropVariant1" /> class.
        /// </summary>
        public CropVariant1()
        {
        }
    }
}