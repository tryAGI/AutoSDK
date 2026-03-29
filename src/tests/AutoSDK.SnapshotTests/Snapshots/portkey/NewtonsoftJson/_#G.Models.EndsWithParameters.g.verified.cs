//HintName: G.Models.EndsWithParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EndsWithParameters
    {
        /// <summary>
        /// Suffix to check for
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suffix", Required = global::Newtonsoft.Json.Required.Always)]
        public string Suffix { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="EndsWithParameters" /> class.
        /// </summary>
        /// <param name="suffix">
        /// Suffix to check for
        /// </param>
        /// <param name="not">
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </param>
        public EndsWithParameters(
            string suffix,
            bool? not)
        {
            this.Suffix = suffix ?? throw new global::System.ArgumentNullException(nameof(suffix));
            this.Not = not;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EndsWithParameters" /> class.
        /// </summary>
        public EndsWithParameters()
        {
        }
    }
}