//HintName: G.Models.ProjectAutomationConfigVariant1ActionVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectAutomationConfigVariant1ActionVariant1
    {
        /// <summary>
        /// The type of action to take
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectAutomationConfigVariant1ActionVariant1TypeJsonConverter))]
        public global::G.ProjectAutomationConfigVariant1ActionVariant1Type Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant1ActionVariant1" /> class.
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
        public ProjectAutomationConfigVariant1ActionVariant1(
            string url,
            global::G.ProjectAutomationConfigVariant1ActionVariant1Type type)
        {
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectAutomationConfigVariant1ActionVariant1" /> class.
        /// </summary>
        public ProjectAutomationConfigVariant1ActionVariant1()
        {
        }
    }
}