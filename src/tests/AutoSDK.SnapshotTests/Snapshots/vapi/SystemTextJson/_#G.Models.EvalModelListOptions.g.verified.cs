//HintName: G.Models.EvalModelListOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvalModelListOptions
    {
        /// <summary>
        /// This is the provider of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EvalModelListOptionsProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EvalModelListOptionsProvider Provider { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalModelListOptions" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the provider of the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalModelListOptions(
            global::G.EvalModelListOptionsProvider provider)
        {
            this.Provider = provider;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalModelListOptions" /> class.
        /// </summary>
        public EvalModelListOptions()
        {
        }
    }
}