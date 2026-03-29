//HintName: G.Models.DetokenizeResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetokenizeResponse200
    {
        /// <summary>
        /// Unique ID for the token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Type of object (tokens).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Timestamp of when the tokens were generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// The name of the model used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The converted tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID for the token.
        /// </param>
        /// <param name="object">
        /// Type of object (tokens).
        /// </param>
        /// <param name="created">
        /// Timestamp of when the tokens were generated.
        /// </param>
        /// <param name="model">
        /// The name of the model used.
        /// </param>
        /// <param name="text">
        /// The converted tokens
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetokenizeResponse200(
            string? id,
            string? @object,
            int? created,
            string? model,
            string? text)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DetokenizeResponse200" /> class.
        /// </summary>
        public DetokenizeResponse200()
        {
        }
    }
}