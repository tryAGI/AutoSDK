//HintName: G.Models.HasIdCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ID-based filtering condition
    /// </summary>
    public sealed partial class HasIdCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ExtendedPointId> HasId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HasIdCondition" /> class.
        /// </summary>
        /// <param name="hasId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HasIdCondition(
            global::System.Collections.Generic.IList<global::G.ExtendedPointId> hasId)
        {
            this.HasId = hasId ?? throw new global::System.ArgumentNullException(nameof(hasId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HasIdCondition" /> class.
        /// </summary>
        public HasIdCondition()
        {
        }
    }
}