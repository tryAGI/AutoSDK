//HintName: G.Models.EmbeddingsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingsRequest
    {
        /// <summary>
        /// The model to use for generating vectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput Input { get; set; }

        /// <summary>
        /// Boolean setting whether to truncate inputs. Not supported by bridgetower.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        public bool? Truncate { get; set; }

        /// <summary>
        /// Which direction to truncate, "Left" or "Right". Not supported by bridgetower.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation_direction")]
        public string? TruncationDirection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The model to use for generating vectors.
        /// </param>
        /// <param name="input"></param>
        /// <param name="truncate">
        /// Boolean setting whether to truncate inputs. Not supported by bridgetower.
        /// </param>
        /// <param name="truncationDirection">
        /// Which direction to truncate, "Left" or "Right". Not supported by bridgetower.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsRequest(
            string model,
            global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput input,
            bool? truncate,
            string? truncationDirection)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Input = input;
            this.Truncate = truncate;
            this.TruncationDirection = truncationDirection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsRequest" /> class.
        /// </summary>
        public EmbeddingsRequest()
        {
        }
    }
}