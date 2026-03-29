//HintName: G.Models.ScalarQuantization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScalarQuantization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scalar", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ScalarQuantizationConfig Scalar { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalarQuantization" /> class.
        /// </summary>
        /// <param name="scalar"></param>
        public ScalarQuantization(
            global::G.ScalarQuantizationConfig scalar)
        {
            this.Scalar = scalar ?? throw new global::System.ArgumentNullException(nameof(scalar));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalarQuantization" /> class.
        /// </summary>
        public ScalarQuantization()
        {
        }
    }
}