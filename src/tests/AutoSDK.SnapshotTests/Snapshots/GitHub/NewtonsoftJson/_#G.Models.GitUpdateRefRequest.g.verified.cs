//HintName: G.Models.GitUpdateRefRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GitUpdateRefRequest
    {
        /// <summary>
        /// The SHA1 value to set this reference to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sha", Required = global::Newtonsoft.Json.Required.Always)]
        public string Sha { get; set; } = default!;

        /// <summary>
        /// Indicates whether to force the update or to make sure the update is a fast-forward update. Leaving this out or setting it to `false` will make sure you're not overwriting work.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GitUpdateRefRequest" /> class.
        /// </summary>
        /// <param name="sha">
        /// The SHA1 value to set this reference to
        /// </param>
        /// <param name="force">
        /// Indicates whether to force the update or to make sure the update is a fast-forward update. Leaving this out or setting it to `false` will make sure you're not overwriting work.<br/>
        /// Default Value: false
        /// </param>
        public GitUpdateRefRequest(
            string sha,
            bool? force)
        {
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Force = force;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GitUpdateRefRequest" /> class.
        /// </summary>
        public GitUpdateRefRequest()
        {
        }
    }
}