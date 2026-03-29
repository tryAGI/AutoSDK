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
        [global::Newtonsoft.Json.JsonProperty("target", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VectorInput Target { get; set; } = default!;

        /// <summary>
        /// Search space will be constrained by these pairs of vectors
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.ContextPair, global::System.Collections.Generic.IList<global::G.ContextPair>, object> Context { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoverInput" /> class.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="context">
        /// Search space will be constrained by these pairs of vectors
        /// </param>
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