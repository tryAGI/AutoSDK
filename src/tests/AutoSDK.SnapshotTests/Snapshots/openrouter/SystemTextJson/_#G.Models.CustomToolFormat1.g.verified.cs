//HintName: G.Models.CustomToolFormat1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomToolFormat1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CustomToolFormatOneOf1TypeJsonConverter))]
        public global::G.CustomToolFormatOneOf1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Definition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syntax")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CustomToolFormatOneOf1SyntaxJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CustomToolFormatOneOf1Syntax Syntax { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolFormat1" /> class.
        /// </summary>
        /// <param name="definition"></param>
        /// <param name="syntax"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomToolFormat1(
            string definition,
            global::G.CustomToolFormatOneOf1Syntax syntax,
            global::G.CustomToolFormatOneOf1Type type)
        {
            this.Type = type;
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
            this.Syntax = syntax;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomToolFormat1" /> class.
        /// </summary>
        public CustomToolFormat1()
        {
        }
    }
}