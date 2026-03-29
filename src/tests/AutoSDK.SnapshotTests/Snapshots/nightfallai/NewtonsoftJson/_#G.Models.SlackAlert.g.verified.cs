//HintName: G.Models.SlackAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SlackAlert
    {
        /// <summary>
        /// Slack channel (e.g., '#general')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public string? Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackAlert" /> class.
        /// </summary>
        /// <param name="target">
        /// Slack channel (e.g., '#general')
        /// </param>
        public SlackAlert(
            string? target)
        {
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackAlert" /> class.
        /// </summary>
        public SlackAlert()
        {
        }
    }
}