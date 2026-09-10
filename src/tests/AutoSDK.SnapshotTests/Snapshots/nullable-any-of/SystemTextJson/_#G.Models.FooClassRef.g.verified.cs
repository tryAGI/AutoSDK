//HintName: G.Models.FooClassRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FooClassRef
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        public string? Label { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("personId")]
        public long? PersonId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FooClassRef" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="personId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FooClassRef(
            string? label,
            long? personId)
        {
            this.Label = label;
            this.PersonId = personId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FooClassRef" /> class.
        /// </summary>
        public FooClassRef()
        {
        }

    }
}