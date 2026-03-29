//HintName: G.Models.Property.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Property
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Property1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Property" /> class.
        /// </summary>
        /// <param name="property1"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Property(
            string property1)
        {
            this.Property1 = property1 ?? throw new global::System.ArgumentNullException(nameof(property1));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Property" /> class.
        /// </summary>
        public Property()
        {
        }
    }
}