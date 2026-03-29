//HintName: G.Models.UppercaseParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UppercaseParameters
    {
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
        /// Initializes a new instance of the <see cref="UppercaseParameters" /> class.
        /// </summary>
        /// <param name="not">
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </param>
        public UppercaseParameters(
            bool? not)
        {
            this.Not = not;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UppercaseParameters" /> class.
        /// </summary>
        public UppercaseParameters()
        {
        }
    }
}