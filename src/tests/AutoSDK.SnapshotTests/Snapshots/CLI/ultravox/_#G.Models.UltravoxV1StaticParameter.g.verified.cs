//HintName: G.Models.UltravoxV1StaticParameter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A static parameter that is unconditionally added when the tool is invoked. This<br/>
    ///  parameter is not exposed to or set by the model.
    /// </summary>
    public sealed partial class UltravoxV1StaticParameter
    {
        /// <summary>
        /// The name of the parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Where the parameter is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UltravoxV1StaticParameterLocationJsonConverter))]
        public global::G.UltravoxV1StaticParameterLocation? Location { get; set; }

        /// <summary>
        /// The value of the parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1StaticParameter" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the parameter.
        /// </param>
        /// <param name="location">
        /// Where the parameter is used.
        /// </param>
        /// <param name="value">
        /// The value of the parameter.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1StaticParameter(
            string? name,
            global::G.UltravoxV1StaticParameterLocation? location,
            object? value)
        {
            this.Name = name;
            this.Location = location;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1StaticParameter" /> class.
        /// </summary>
        public UltravoxV1StaticParameter()
        {
        }
    }
}