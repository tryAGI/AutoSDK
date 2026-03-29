//HintName: G.Models.DeleteAPIKeyResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteAPIKeyResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hashedKey")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HashedKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAPIKeyResponseVariant1" /> class.
        /// </summary>
        /// <param name="hashedKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteAPIKeyResponseVariant1(
            string hashedKey)
        {
            this.HashedKey = hashedKey ?? throw new global::System.ArgumentNullException(nameof(hashedKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteAPIKeyResponseVariant1" /> class.
        /// </summary>
        public DeleteAPIKeyResponseVariant1()
        {
        }
    }
}