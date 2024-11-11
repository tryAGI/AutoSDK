//HintName: G.Models.StatusCheckPolicyCheck.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StatusCheckPolicyCheck
    {
        /// <summary>
        /// Example: continuous-integration/travis-ci
        /// </summary>
        /// <example>continuous-integration/travis-ci</example>
        [global::Newtonsoft.Json.JsonProperty("context", Required = global::Newtonsoft.Json.Required.Always)]
        public string Context { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("app_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int? AppId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCheckPolicyCheck" /> class.
        /// </summary>
        /// <param name="context">
        /// Example: continuous-integration/travis-ci
        /// </param>
        /// <param name="appId"></param>
        public StatusCheckPolicyCheck(
            string context,
            int? appId)
        {
            this.Context = context ?? throw new global::System.ArgumentNullException(nameof(context));
            this.AppId = appId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusCheckPolicyCheck" /> class.
        /// </summary>
        public StatusCheckPolicyCheck()
        {
        }
    }
}