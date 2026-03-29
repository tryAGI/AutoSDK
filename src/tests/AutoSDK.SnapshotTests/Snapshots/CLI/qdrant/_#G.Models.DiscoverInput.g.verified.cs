//HintName: G.Models.DiscoverInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DiscoverInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VectorInput Target { get; set; }

        /// <summary>
        /// Search space will be constrained by these pairs of vectors
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ContextPair, global::System.Collections.Generic.IList<global::G.ContextPair>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.ContextPair, global::System.Collections.Generic.IList<global::G.ContextPair>, object> Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverInput" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="context">
        /// Search space will be constrained by these pairs of vectors
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DiscoverInput(
            global::G.VectorInput target,
            global::G.AnyOf<global::G.ContextPair, global::System.Collections.Generic.IList<global::G.ContextPair>, object> context)
        {
            this.Target = target;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverInput" /> class.
        /// </summary>
        public DiscoverInput()
        {
        }
    }
}