//HintName: G.Models.TypeB.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TypeB
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public int? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("back")]
        public global::G.TypeA? Back { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeB" /> class.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="back"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TypeB(
            int? value,
            global::G.TypeA? back)
        {
            this.Value = value;
            this.Back = back;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeB" /> class.
        /// </summary>
        public TypeB()
        {
        }
    }
}