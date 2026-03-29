//HintName: G.Models.ConvertDocumentsRequestTargetDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConvertDocumentsRequestTargetDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConvertDocumentsRequestTargetDiscriminatorKindJsonConverter))]
        public global::G.ConvertDocumentsRequestTargetDiscriminatorKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentsRequestTargetDiscriminator" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConvertDocumentsRequestTargetDiscriminator(
            global::G.ConvertDocumentsRequestTargetDiscriminatorKind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentsRequestTargetDiscriminator" /> class.
        /// </summary>
        public ConvertDocumentsRequestTargetDiscriminator()
        {
        }
    }
}