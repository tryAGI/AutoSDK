//HintName: G.Models.Guard.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A Guard configuration for validating LLM outputs.
    /// </summary>
    public sealed partial class Guard
    {
        /// <summary>
        /// The unique identifier for the Guard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name for the Guard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description that concisely states the expected behaviour or purpose of the Guard.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validators")]
        public global::System.Collections.Generic.IList<global::G.ValidatorReference>? Validators { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public global::System.Collections.Generic.IList<global::G.Call>? History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Guard" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the Guard.
        /// </param>
        /// <param name="name">
        /// The name for the Guard.
        /// </param>
        /// <param name="description">
        /// A description that concisely states the expected behaviour or purpose of the Guard.
        /// </param>
        /// <param name="validators"></param>
        /// <param name="history">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Guard(
            string id,
            string name,
            string? description,
            global::System.Collections.Generic.IList<global::G.ValidatorReference>? validators,
            global::System.Collections.Generic.IList<global::G.Call>? history)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Validators = validators;
            this.History = history;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Guard" /> class.
        /// </summary>
        public Guard()
        {
        }
    }
}