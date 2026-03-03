//HintName: G.Models.TypeA.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TypeA
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linked")]
        public global::G.TypeB? Linked { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeA" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="linked"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TypeA(
            string? name,
            global::G.TypeB? linked)
        {
            this.Name = name;
            this.Linked = linked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeA" /> class.
        /// </summary>
        public TypeA()
        {
        }
    }
}