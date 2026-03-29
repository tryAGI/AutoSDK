//HintName: G.Models.CompletionsResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompletionsResponse200
    {
        /// <summary>
        /// Unique ID for the completion.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Type of object (completion).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Timestamp of when the completion was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created")]
        public int? Created { get; set; }

        /// <summary>
        /// The model used for generating the result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The set of result choices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("choices")]
        public global::System.Collections.Generic.IList<global::G.CompletionsPostResponsesContentApplicationJsonSchemaChoicesItems>? Choices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID for the completion.
        /// </param>
        /// <param name="object">
        /// Type of object (completion).
        /// </param>
        /// <param name="created">
        /// Timestamp of when the completion was created.
        /// </param>
        /// <param name="model">
        /// The model used for generating the result.
        /// </param>
        /// <param name="choices">
        /// The set of result choices.
        /// </param>
        public CompletionsResponse200(
            string? id,
            string? @object,
            int? created,
            string? model,
            global::System.Collections.Generic.IList<global::G.CompletionsPostResponsesContentApplicationJsonSchemaChoicesItems>? choices)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Choices = choices;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionsResponse200" /> class.
        /// </summary>
        public CompletionsResponse200()
        {
        }
    }
}