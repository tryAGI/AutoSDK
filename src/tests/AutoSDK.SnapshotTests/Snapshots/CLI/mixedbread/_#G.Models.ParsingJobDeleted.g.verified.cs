//HintName: G.Models.ParsingJobDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A deleted parsing job.
    /// </summary>
    public sealed partial class ParsingJobDeleted
    {
        /// <summary>
        /// The ID of the deleted job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Whether the job was deleted<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// The type of the object<br/>
        /// Default Value: parsing_job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJobDeleted" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the deleted job
        /// </param>
        /// <param name="deleted">
        /// Whether the job was deleted<br/>
        /// Default Value: true
        /// </param>
        /// <param name="object">
        /// The type of the object<br/>
        /// Default Value: parsing_job
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParsingJobDeleted(
            string id,
            bool? deleted,
            string? @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Deleted = deleted;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParsingJobDeleted" /> class.
        /// </summary>
        public ParsingJobDeleted()
        {
        }
    }
}