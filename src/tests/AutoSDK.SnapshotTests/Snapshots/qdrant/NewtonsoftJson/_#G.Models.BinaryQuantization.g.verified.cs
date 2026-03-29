//HintName: G.Models.BinaryQuantization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BinaryQuantization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("binary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BinaryQuantizationConfig Binary { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryQuantization" /> class.
        /// </summary>
        /// <param name="binary"></param>
        public BinaryQuantization(
            global::G.BinaryQuantizationConfig binary)
        {
            this.Binary = binary ?? throw new global::System.ArgumentNullException(nameof(binary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BinaryQuantization" /> class.
        /// </summary>
        public BinaryQuantization()
        {
        }
    }
}