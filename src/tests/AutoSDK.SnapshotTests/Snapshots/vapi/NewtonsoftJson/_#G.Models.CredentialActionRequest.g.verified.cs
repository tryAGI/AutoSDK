//HintName: G.Models.CredentialActionRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CredentialActionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ActionName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input", Required = global::Newtonsoft.Json.Required.Always)]
        public object Input { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialActionRequest" /> class.
        /// </summary>
        /// <param name="actionName"></param>
        /// <param name="input"></param>
        public CredentialActionRequest(
            string actionName,
            object input)
        {
            this.ActionName = actionName ?? throw new global::System.ArgumentNullException(nameof(actionName));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CredentialActionRequest" /> class.
        /// </summary>
        public CredentialActionRequest()
        {
        }
    }
}