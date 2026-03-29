//HintName: G.Models.ModelsDescriptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsDescriptions
    {
        /// <summary>
        /// List of models that are loaded by model manager.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("models", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ModelDescriptionEntity> Models { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsDescriptions" /> class.
        /// </summary>
        /// <param name="models">
        /// List of models that are loaded by model manager.
        /// </param>
        public ModelsDescriptions(
            global::System.Collections.Generic.IList<global::G.ModelDescriptionEntity> models)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsDescriptions" /> class.
        /// </summary>
        public ModelsDescriptions()
        {
        }
    }
}