//HintName: G.Models.LanguageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string LanguageId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageResponseModel" /> class.
        /// </summary>
        /// <param name="languageId"></param>
        /// <param name="name"></param>
        public LanguageResponseModel(
            string languageId,
            string name)
        {
            this.LanguageId = languageId ?? throw new global::System.ArgumentNullException(nameof(languageId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageResponseModel" /> class.
        /// </summary>
        public LanguageResponseModel()
        {
        }
    }
}