//HintName: G.Models.UltravoxV1AutomaticParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A parameter that is automatically set by the system.
    /// </summary>
    public sealed partial class UltravoxV1AutomaticParameter
    {
        /// <summary>
        /// The name of the parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Where the parameter is used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public global::G.UltravoxV1AutomaticParameterLocation? Location { get; set; }

        /// <summary>
        /// The value to set for the parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("knownValue")]
        public global::G.UltravoxV1AutomaticParameterKnownValue? KnownValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1AutomaticParameter" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the parameter.
        /// </param>
        /// <param name="location">
        /// Where the parameter is used.
        /// </param>
        /// <param name="knownValue">
        /// The value to set for the parameter.
        /// </param>
        public UltravoxV1AutomaticParameter(
            string? name,
            global::G.UltravoxV1AutomaticParameterLocation? location,
            global::G.UltravoxV1AutomaticParameterKnownValue? knownValue)
        {
            this.Name = name;
            this.Location = location;
            this.KnownValue = knownValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1AutomaticParameter" /> class.
        /// </summary>
        public UltravoxV1AutomaticParameter()
        {
        }
    }
}