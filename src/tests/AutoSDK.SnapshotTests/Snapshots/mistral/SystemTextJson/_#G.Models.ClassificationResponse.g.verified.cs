//HintName: G.Models.ClassificationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassificationResponse
    {
        /// <summary>
        /// Example: mod-e5cc70bb28c444948073e77776eb30ef
        /// </summary>
        /// <example>mod-e5cc70bb28c444948073e77776eb30ef</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::G.ClassificationTargetResult>> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: mod-e5cc70bb28c444948073e77776eb30ef
        /// </param>
        /// <param name="model"></param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassificationResponse(
            string id,
            string model,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, global::G.ClassificationTargetResult>> results)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassificationResponse" /> class.
        /// </summary>
        public ClassificationResponse()
        {
        }
    }
}