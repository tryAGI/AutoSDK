//HintName: G.Models.UpdateResponseVariant1Error.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error object in case of errors
    /// </summary>
    public sealed partial class UpdateResponseVariant1Error
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResponseVariant1Error" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="kind"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateResponseVariant1Error(
            string description,
            string kind,
            string? details)
        {
            this.Details = details;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateResponseVariant1Error" /> class.
        /// </summary>
        public UpdateResponseVariant1Error()
        {
        }
    }
}