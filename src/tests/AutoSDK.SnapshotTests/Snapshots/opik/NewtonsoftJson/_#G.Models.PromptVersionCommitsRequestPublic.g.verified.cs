//HintName: G.Models.PromptVersionCommitsRequestPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptVersionCommitsRequestPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Commits { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionCommitsRequestPublic" /> class.
        /// </summary>
        /// <param name="commits"></param>
        public PromptVersionCommitsRequestPublic(
            global::System.Collections.Generic.IList<string> commits)
        {
            this.Commits = commits ?? throw new global::System.ArgumentNullException(nameof(commits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptVersionCommitsRequestPublic" /> class.
        /// </summary>
        public PromptVersionCommitsRequestPublic()
        {
        }
    }
}