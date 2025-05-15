﻿//HintName: G.Models.OpenAIEmbeddingsIn.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// sequences to embed<br/>
        /// Example: [I like chocolate]
        /// </summary>
        /// <example>[I like chocolate]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<string>, string> Input { get; set; }

        /// <summary>
        /// format used when encoding<br/>
        /// Default Value: float
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OpenAIEmbeddingsInEncodingFormatJsonConverter))]
        public global::G.OpenAIEmbeddingsInEncodingFormat? EncodingFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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