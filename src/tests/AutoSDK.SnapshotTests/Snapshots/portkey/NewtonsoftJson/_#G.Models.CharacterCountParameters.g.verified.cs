//HintName: G.Models.CharacterCountParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CharacterCountParameters
    {
        /// <summary>
        /// Minimum number of characters to allow<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minCharacters")]
        public double? MinCharacters { get; set; }

        /// <summary>
        /// Maximum number of characters to allow<br/>
        /// Default Value: 9999999
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxCharacters")]
        public double? MaxCharacters { get; set; }

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
        /// Initializes a new instance of the <see cref="CharacterCountParameters" /> class.
        /// </summary>
        /// <param name="minCharacters">
        /// Minimum number of characters to allow<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="maxCharacters">
        /// Maximum number of characters to allow<br/>
        /// Default Value: 9999999
        /// </param>
        /// <param name="not">
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </param>
        public CharacterCountParameters(
            double? minCharacters,
            double? maxCharacters,
            bool? not)
        {
            this.MinCharacters = minCharacters;
            this.MaxCharacters = maxCharacters;
            this.Not = not;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterCountParameters" /> class.
        /// </summary>
        public CharacterCountParameters()
        {
        }
    }
}