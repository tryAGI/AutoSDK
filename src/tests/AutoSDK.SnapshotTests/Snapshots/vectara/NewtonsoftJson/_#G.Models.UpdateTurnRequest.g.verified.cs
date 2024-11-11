//HintName: G.Models.UpdateTurnRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateTurnRequest
    {
        /// <summary>
        /// Indicates whether to disable a turn. It will disable this turn and all subsequent turns.<br/>
        /// Enabling a turn is not implemented.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTurnRequest" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Indicates whether to disable a turn. It will disable this turn and all subsequent turns.<br/>
        /// Enabling a turn is not implemented.<br/>
        /// Example: false
        /// </param>
        public UpdateTurnRequest(
            bool? enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTurnRequest" /> class.
        /// </summary>
        public UpdateTurnRequest()
        {
        }
    }
}