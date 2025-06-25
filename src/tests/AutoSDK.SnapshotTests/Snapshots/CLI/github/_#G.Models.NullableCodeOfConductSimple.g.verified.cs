//HintName: G.Models.NullableCodeOfConductSimple.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Code of Conduct Simple
    /// </summary>
    public sealed partial class NullableCodeOfConductSimple
    {
        /// <summary>
        /// Example: https://api.github.com/repos/github/docs/community/code_of_conduct
        /// </summary>
        /// <example>https://api.github.com/repos/github/docs/community/code_of_conduct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: citizen_code_of_conduct
        /// </summary>
        /// <example>citizen_code_of_conduct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Example: Citizen Code of Conduct
        /// </summary>
        /// <example>Citizen Code of Conduct</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: https://github.com/github/docs/blob/main/CODE_OF_CONDUCT.md
        /// </summary>
        /// <example>https://github.com/github/docs/blob/main/CODE_OF_CONDUCT.md</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? HtmlUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NullableCodeOfConductSimple" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NullableCodeOfConductSimple(
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
        /// Initializes a new instance of the <see cref="NullableCodeOfConductSimple" /> class.
        /// </summary>
        public NullableCodeOfConductSimple()
        {
        }
    }
}