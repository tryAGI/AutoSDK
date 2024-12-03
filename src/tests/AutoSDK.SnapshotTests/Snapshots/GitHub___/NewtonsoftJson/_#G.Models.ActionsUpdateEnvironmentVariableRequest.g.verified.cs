//HintName: G.Models.ActionsUpdateEnvironmentVariableRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsUpdateEnvironmentVariableRequest
    {
        /// <summary>
        /// The name of the variable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The value of the variable.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsUpdateEnvironmentVariableRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the variable.
        /// </param>
        /// <param name="value">
        /// The value of the variable.
        /// </param>
        public ActionsUpdateEnvironmentVariableRequest(
            string? name,
            string? value)
        {
            this.Name = name;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsUpdateEnvironmentVariableRequest" /> class.
        /// </summary>
        public ActionsUpdateEnvironmentVariableRequest()
        {
        }
    }
}