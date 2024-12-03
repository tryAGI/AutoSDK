//HintName: G.Models.DependabotAlertSecurityAdvisoryIdentifier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An advisory identifier.<br/>
    /// Included only in responses
    /// </summary>
    public sealed partial class DependabotAlertSecurityAdvisoryIdentifier
    {
        /// <summary>
        /// The type of advisory identifier.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DependabotAlertSecurityAdvisoryIdentifierType Type { get; set; } = default!;

        /// <summary>
        /// The value of the advisory identifer.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertSecurityAdvisoryIdentifier" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of advisory identifier.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="value">
        /// The value of the advisory identifer.<br/>
        /// Included only in responses
        /// </param>
        public DependabotAlertSecurityAdvisoryIdentifier(
            global::G.DependabotAlertSecurityAdvisoryIdentifierType type = default!,
            string value = default!)
        {
            this.Type = type;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DependabotAlertSecurityAdvisoryIdentifier" /> class.
        /// </summary>
        public DependabotAlertSecurityAdvisoryIdentifier()
        {
        }
    }
}