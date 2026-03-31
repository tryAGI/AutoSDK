//HintName: G.Models.PickExpressiveVideoExpressivePublicAllowedAttributesError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PickExpressiveVideoExpressivePublicAllowedAttributesError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public object? Details { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal")]
        public string? Internal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PickExpressiveVideoExpressivePublicAllowedAttributesError" /> class.
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="description"></param>
        /// <param name="details"></param>
        /// <param name="internal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PickExpressiveVideoExpressivePublicAllowedAttributesError(
            string kind,
            string description,
            object? details,
            string? @internal)
        {
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Details = details;
            this.Internal = @internal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PickExpressiveVideoExpressivePublicAllowedAttributesError" /> class.
        /// </summary>
        public PickExpressiveVideoExpressivePublicAllowedAttributesError()
        {
        }
    }
}