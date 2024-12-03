//HintName: G.Models.PullRequestMinimal.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PullRequestMinimal
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public long Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("head", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestMinimalHead Head { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PullRequestMinimalBase Base { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestMinimal" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="url"></param>
        /// <param name="head"></param>
        /// <param name="base"></param>
        public PullRequestMinimal(
            long id,
            int number,
            string url,
            global::G.PullRequestMinimalHead head,
            global::G.PullRequestMinimalBase @base)
        {
            this.Id = id;
            this.Number = number;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Head = head ?? throw new global::System.ArgumentNullException(nameof(head));
            this.Base = @base ?? throw new global::System.ArgumentNullException(nameof(@base));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestMinimal" /> class.
        /// </summary>
        public PullRequestMinimal()
        {
        }
    }
}