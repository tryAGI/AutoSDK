//HintName: G.Models.ContainsCodeParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainsCodeParameters
    {
        /// <summary>
        /// Code format to check for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ContainsCodeParametersFormat Format { get; set; } = default!;

        /// <summary>
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("not")]
        public bool? Not { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsCodeParameters" /> class.
        /// </summary>
        /// <param name="format">
        /// Code format to check for
        /// </param>
        /// <param name="not">
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </param>
        public ContainsCodeParameters(
            global::G.ContainsCodeParametersFormat format,
            bool? not)
        {
            this.Format = format;
            this.Not = not;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsCodeParameters" /> class.
        /// </summary>
        public ContainsCodeParameters()
        {
        }
    }
}