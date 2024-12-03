//HintName: G.Models.LicenseContentLinks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LicenseContentLinks
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("git")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Git { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Html { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("self")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Self { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseContentLinks" /> class.
        /// </summary>
        /// <param name="git"></param>
        /// <param name="html"></param>
        /// <param name="self"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LicenseContentLinks(
            string? git,
            string? html,
            string self)
        {
            this.Git = git ?? throw new global::System.ArgumentNullException(nameof(git));
            this.Html = html ?? throw new global::System.ArgumentNullException(nameof(html));
            this.Self = self ?? throw new global::System.ArgumentNullException(nameof(self));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseContentLinks" /> class.
        /// </summary>
        public LicenseContentLinks()
        {
        }
    }
}