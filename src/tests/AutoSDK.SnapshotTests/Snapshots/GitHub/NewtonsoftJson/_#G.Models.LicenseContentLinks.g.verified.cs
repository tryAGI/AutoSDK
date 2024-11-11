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
        [global::Newtonsoft.Json.JsonProperty("git", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Git { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("html", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Html { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("self", Required = global::Newtonsoft.Json.Required.Always)]
        public string Self { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LicenseContentLinks" /> class.
        /// </summary>
        /// <param name="git"></param>
        /// <param name="html"></param>
        /// <param name="self"></param>
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