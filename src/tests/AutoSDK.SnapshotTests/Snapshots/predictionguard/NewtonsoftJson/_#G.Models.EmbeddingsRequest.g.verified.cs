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
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput Input { get; set; } = default!;

        /// <summary>
        /// Boolean setting whether to truncate inputs. Not supported by bridgetower.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncate")]
        public bool? Truncate { get; set; }

        /// <summary>
        /// Which direction to truncate, "Left" or "Right". Not supported by bridgetower.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("truncation_direction")]
        public string? TruncationDirection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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