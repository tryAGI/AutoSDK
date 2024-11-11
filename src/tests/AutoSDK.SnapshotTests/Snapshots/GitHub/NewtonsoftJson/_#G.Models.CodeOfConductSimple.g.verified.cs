//HintName: G.Models.CodeOfConductSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Code of Conduct Simple
    /// </summary>
    public sealed partial class CodeOfConductSimple
    {
        /// <summary>
        /// Example: https://api.github.com/repos/github/docs/community/code_of_conduct
        /// </summary>
        /// <example>https://api.github.com/repos/github/docs/community/code_of_conduct</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: citizen_code_of_conduct
        /// </summary>
        /// <example>citizen_code_of_conduct</example>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Example: Citizen Code of Conduct
        /// </summary>
        /// <example>Citizen Code of Conduct</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: https://github.com/github/docs/blob/main/CODE_OF_CONDUCT.md
        /// </summary>
        /// <example>https://github.com/github/docs/blob/main/CODE_OF_CONDUCT.md</example>
        [global::Newtonsoft.Json.JsonProperty("html_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string? HtmlUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeOfConductSimple" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/repos/github/docs/community/code_of_conduct
        /// </param>
        /// <param name="key">
        /// Example: citizen_code_of_conduct
        /// </param>
        /// <param name="name">
        /// Example: Citizen Code of Conduct
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/github/docs/blob/main/CODE_OF_CONDUCT.md
        /// </param>
        public CodeOfConductSimple(
            string url,
            string key,
            string name,
            string? htmlUrl)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeOfConductSimple" /> class.
        /// </summary>
        public CodeOfConductSimple()
        {
        }
    }
}