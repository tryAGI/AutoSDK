//HintName: G.Models.OpenAIEmbeddingsIn.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIEmbeddingsIn
    {
        /// <summary>
        /// model name<br/>
        /// Example: thenlper/gte-large
        /// </summary>
        /// <example>thenlper/gte-large</example>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// sequences to embed<br/>
        /// Example: [I like chocolate]
        /// </summary>
        /// <example>[I like chocolate]</example>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, string> Input { get; set; } = default!;

        /// <summary>
        /// format used when encoding<br/>
        /// Default Value: float
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("encoding_format")]
        public global::G.OpenAIEmbeddingsInEncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIEmbeddingsIn" /> class.
        /// </summary>
        /// <param name="model">
        /// model name<br/>
        /// Example: thenlper/gte-large
        /// </param>
        /// <param name="input">
        /// sequences to embed<br/>
        /// Example: [I like chocolate]
        /// </param>
        /// <param name="encodingFormat">
        /// format used when encoding<br/>
        /// Default Value: float
        /// </param>
        public OpenAIEmbeddingsIn(
            string model,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string> input,
            global::G.OpenAIEmbeddingsInEncodingFormat? encodingFormat)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.EncodingFormat = encodingFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIEmbeddingsIn" /> class.
        /// </summary>
        public OpenAIEmbeddingsIn()
        {
        }
    }
}