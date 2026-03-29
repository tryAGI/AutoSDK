//HintName: G.Models.FunctionsInvokeRequestSessionCreateParamsBrowserSettingsContext.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionsInvokeRequestSessionCreateParamsBrowserSettingsContext
    {
        /// <summary>
        /// The Context ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Whether or not to persist the context after browsing. Defaults to `false`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("persist")]
        public bool? Persist { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParamsBrowserSettingsContext" /> class.
        /// </summary>
        /// <param name="id">
        /// The Context ID.
        /// </param>
        /// <param name="persist">
        /// Whether or not to persist the context after browsing. Defaults to `false`.
        /// </param>
        public FunctionsInvokeRequestSessionCreateParamsBrowserSettingsContext(
            string id,
            bool? persist)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Persist = persist;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionsInvokeRequestSessionCreateParamsBrowserSettingsContext" /> class.
        /// </summary>
        public FunctionsInvokeRequestSessionCreateParamsBrowserSettingsContext()
        {
        }
    }
}