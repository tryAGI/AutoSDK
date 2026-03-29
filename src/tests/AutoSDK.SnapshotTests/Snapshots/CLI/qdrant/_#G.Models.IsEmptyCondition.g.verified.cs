//HintName: G.Models.IsEmptyCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Select points with empty payload for a specified field
    /// </summary>
    public sealed partial class IsEmptyCondition
    {
        /// <summary>
        /// Payload field
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_empty")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PayloadField IsEmpty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IsEmptyCondition" /> class.
        /// </summary>
        /// <param name="isEmpty">
        /// Payload field
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IsEmptyCondition(
            global::G.PayloadField isEmpty)
        {
            this.IsEmpty = isEmpty ?? throw new global::System.ArgumentNullException(nameof(isEmpty));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IsEmptyCondition" /> class.
        /// </summary>
        public IsEmptyCondition()
        {
        }
    }
}