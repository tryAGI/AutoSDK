//HintName: G.Models.PromptGoogleInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptGoogleInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"google"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "google";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("google", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptGoogleInvocationParametersContent Google { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptGoogleInvocationParameters" /> class.
        /// </summary>
        /// <param name="google"></param>
        /// <param name="type"></param>
        public PromptGoogleInvocationParameters(
            global::G.PromptGoogleInvocationParametersContent google,
            string type = "google")
        {
            this.Type = type;
            this.Google = google ?? throw new global::System.ArgumentNullException(nameof(google));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptGoogleInvocationParameters" /> class.
        /// </summary>
        public PromptGoogleInvocationParameters()
        {
        }
    }
}