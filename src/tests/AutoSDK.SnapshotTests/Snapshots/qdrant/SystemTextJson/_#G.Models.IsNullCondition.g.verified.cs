//HintName: G.Models.IsNullCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Select points with null payload for a specified field
    /// </summary>
    public sealed partial class IsNullCondition
    {
        /// <summary>
        /// Payload field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_null")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PayloadField IsNull { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IsNullCondition" /> class.
        /// </summary>
        /// <param name="isNull">
        /// Payload field
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IsNullCondition(
            global::G.PayloadField isNull)
        {
            this.IsNull = isNull ?? throw new global::System.ArgumentNullException(nameof(isNull));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IsNullCondition" /> class.
        /// </summary>
        public IsNullCondition()
        {
        }
    }
}