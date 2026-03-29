//HintName: G.Models.IndexesVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Do not use any index, scan whole vector collection during search. Guarantee 100% precision, but may be time consuming on large collections.
    /// </summary>
    public sealed partial class IndexesVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.IndexesVariant1TypeJsonConverter))]
        public global::G.IndexesVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("options")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Options { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesVariant1" /> class.
        /// </summary>
        /// <param name="options"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexesVariant1(
            object options,
            global::G.IndexesVariant1Type type)
        {
            this.Type = type;
            this.Options = options ?? throw new global::System.ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesVariant1" /> class.
        /// </summary>
        public IndexesVariant1()
        {
        }
    }
}