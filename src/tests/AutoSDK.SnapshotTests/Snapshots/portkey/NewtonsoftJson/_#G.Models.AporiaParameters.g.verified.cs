//HintName: G.Models.AporiaParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AporiaParameters
    {
        /// <summary>
        /// Aporia Project ID to validate
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projectID", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectID { get; set; } = default!;

        /// <summary>
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AporiaParameters" /> class.
        /// </summary>
        /// <param name="projectID">
        /// Aporia Project ID to validate
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 5000
        /// </param>
        public AporiaParameters(
            string projectID,
            double? timeout)
        {
            this.ProjectID = projectID ?? throw new global::System.ArgumentNullException(nameof(projectID));
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AporiaParameters" /> class.
        /// </summary>
        public AporiaParameters()
        {
        }
    }
}