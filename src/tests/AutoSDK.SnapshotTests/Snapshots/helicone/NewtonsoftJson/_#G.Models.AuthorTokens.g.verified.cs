//HintName: G.Models.AuthorTokens.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthorTokens
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("author", Required = global::Newtonsoft.Json.Required.Always)]
        public string Author { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("percentage", Required = global::Newtonsoft.Json.Required.Always)]
        public double Percentage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorTokens" /> class.
        /// </summary>
        /// <param name="author"></param>
        /// <param name="totalTokens"></param>
        /// <param name="percentage"></param>
        public AuthorTokens(
            string author,
            double totalTokens,
            double percentage)
        {
            this.Author = author ?? throw new global::System.ArgumentNullException(nameof(author));
            this.TotalTokens = totalTokens;
            this.Percentage = percentage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorTokens" /> class.
        /// </summary>
        public AuthorTokens()
        {
        }
    }
}