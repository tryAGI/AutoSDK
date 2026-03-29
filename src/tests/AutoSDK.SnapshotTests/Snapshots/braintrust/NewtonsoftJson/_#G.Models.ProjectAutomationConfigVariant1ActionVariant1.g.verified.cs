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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ProjectAutomationConfigVariant1ActionVariant1Type Type { get; set; }

        /// <summary>
        /// The webhook URL to send the request to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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