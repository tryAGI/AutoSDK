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
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public string? Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackAlert" /> class.
        /// </summary>
        /// <param name="target">
        /// Slack channel (e.g., '#general')
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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