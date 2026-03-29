//HintName: G.Models.PowParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PowParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression Base { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exponent", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Expression Exponent { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PowParams" /> class.
        /// </summary>
        /// <param name="base"></param>
        /// <param name="exponent"></param>
        public PowParams(
            global::G.Expression @base,
            global::G.Expression exponent)
        {
            this.Base = @base;
            this.Exponent = exponent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowParams" /> class.
        /// </summary>
        public PowParams()
        {
        }
    }
}