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
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EvalModelListOptionsProviderJsonConverter))]
        public global::G.EvalModelListOptionsProvider Provider { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalModelListOptions" /> class.
        /// </summary>
        /// <param name="provider">
        /// This is the provider of the model.
        /// </param>
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