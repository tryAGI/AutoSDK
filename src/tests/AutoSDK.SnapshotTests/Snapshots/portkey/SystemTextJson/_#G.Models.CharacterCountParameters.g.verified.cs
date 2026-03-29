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
        [global::System.Text.Json.Serialization.JsonPropertyName("minCharacters")]
        public double? MinCharacters { get; set; }

        /// <summary>
        /// Maximum number of characters to allow<br/>
        /// Default Value: 9999999
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCharacters")]
        public double? MaxCharacters { get; set; }

        /// <summary>
        /// If true, the verdict will be inverted<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("not")]
        public bool? Not { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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