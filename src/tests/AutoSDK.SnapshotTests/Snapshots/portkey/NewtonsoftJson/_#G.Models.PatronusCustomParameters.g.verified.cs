//HintName: G.Models.PatronusCustomParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PatronusCustomParameters
    {
        /// <summary>
        /// Custom evaluator profile name (e.g., system:is-concise)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("profile", Required = global::Newtonsoft.Json.Required.Always)]
        public string Profile { get; set; } = default!;

        /// <summary>
        /// Timeout in milliseconds<br/>
        /// Default Value: 15000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PatronusCustomParameters" /> class.
        /// </summary>
        /// <param name="profile">
        /// Custom evaluator profile name (e.g., system:is-concise)
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 15000
        /// </param>
        public PatronusCustomParameters(
            string profile,
            double? timeout)
        {
            this.Profile = profile ?? throw new global::System.ArgumentNullException(nameof(profile));
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatronusCustomParameters" /> class.
        /// </summary>
        public PatronusCustomParameters()
        {
        }
    }
}