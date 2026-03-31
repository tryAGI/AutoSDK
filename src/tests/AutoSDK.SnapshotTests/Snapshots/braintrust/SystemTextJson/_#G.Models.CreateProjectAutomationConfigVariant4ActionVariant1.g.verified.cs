//HintName: G.Models.CreateProjectAutomationConfigVariant4ActionVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateProjectAutomationConfigVariant4ActionVariant1
    {
        /// <summary>
        /// The type of action to take
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter))]
        public global::G.CreateProjectAutomationConfigVariant4ActionVariant1Type Type { get; set; }

        /// <summary>
        /// The webhook URL to send the request to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant4ActionVariant1" /> class.
        /// </summary>
        /// <param name="url">
        /// The webhook URL to send the request to
        /// </param>
        /// <param name="type">
        /// The type of action to take
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateProjectAutomationConfigVariant4ActionVariant1(
            string url,
            global::G.CreateProjectAutomationConfigVariant4ActionVariant1Type type)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProjectAutomationConfigVariant4ActionVariant1" /> class.
        /// </summary>
        public CreateProjectAutomationConfigVariant4ActionVariant1()
        {
        }
    }
}