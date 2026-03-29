//HintName: G.Models.InjectionResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InjectionResponse200
    {
        /// <summary>
        /// Unique ID for the injection check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Type of object (injection_check).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Timestamp of when the injection check was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// The set of vectorized data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::System.Collections.Generic.IList<global::G.InjectionPostResponsesContentApplicationJsonSchemaChecksItems>? Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InjectionResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID for the injection check.
        /// </param>
        /// <param name="object">
        /// Type of object (injection_check).
        /// </param>
        /// <param name="created">
        /// Timestamp of when the injection check was created.
        /// </param>
        /// <param name="checks">
        /// The set of vectorized data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InjectionResponse200(
            string? id,
            string? @object,
            int? created,
            global::System.Collections.Generic.IList<global::G.InjectionPostResponsesContentApplicationJsonSchemaChecksItems>? checks)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Checks = checks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InjectionResponse200" /> class.
        /// </summary>
        public InjectionResponse200()
        {
        }
    }
}