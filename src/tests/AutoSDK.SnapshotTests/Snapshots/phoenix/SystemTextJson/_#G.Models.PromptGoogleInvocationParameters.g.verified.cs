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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "google";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("google")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptGoogleInvocationParametersContent Google { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptGoogleInvocationParameters" /> class.
        /// </summary>
        /// <param name="google"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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