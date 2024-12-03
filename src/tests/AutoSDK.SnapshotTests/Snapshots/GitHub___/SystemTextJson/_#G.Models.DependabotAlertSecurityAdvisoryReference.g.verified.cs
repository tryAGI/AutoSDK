//HintName: G.Models.DependabotAlertSecurityAdvisoryReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A link to additional advisory information.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisoryReference
    {
        /// <summary>
        /// The URL of the reference.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertSecurityAdvisoryReference" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the reference.<br/>
        /// Included only in responses
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DependabotAlertSecurityAdvisoryReference(
            string url = default!)
        {
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertSecurityAdvisoryReference" /> class.
        /// </summary>
        public DependabotAlertSecurityAdvisoryReference()
        {
        }
    }
}