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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("head")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PullRequestMinimalHead Head { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PullRequestMinimalBase Base { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestMinimal" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="number"></param>
        /// <param name="url"></param>
        /// <param name="head"></param>
        /// <param name="base"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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