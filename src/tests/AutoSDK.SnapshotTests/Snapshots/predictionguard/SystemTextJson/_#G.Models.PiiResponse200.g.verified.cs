//HintName: G.Models.PiiResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PiiResponse200
    {
        /// <summary>
        /// Unique ID for the PII check.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Type of object (pii_check).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Timestamp of when the PII check was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// The set of vectorized data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checks")]
        public global::System.Collections.Generic.IList<global::G.PiiPostResponsesContentApplicationJsonSchemaChecksItems>? Checks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiResponse200" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique ID for the PII check.
        /// </param>
        /// <param name="object">
        /// Type of object (pii_check).
        /// </param>
        /// <param name="created">
        /// Timestamp of when the PII check was created.
        /// </param>
        /// <param name="checks">
        /// The set of vectorized data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PiiResponse200(
            string? id,
            string? @object,
            int? created,
            global::System.Collections.Generic.IList<global::G.PiiPostResponsesContentApplicationJsonSchemaChecksItems>? checks)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Checks = checks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PiiResponse200" /> class.
        /// </summary>
        public PiiResponse200()
        {
        }
    }
}