//HintName: G.Models.AdminCreateDeveloperKeyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AdminCreateDeveloperKeyRequest
    {
        /// <summary>
        /// API key label. The default value is `DeepL API Key`.<br/>
        /// Example: developer key prod
        /// </summary>
        /// <example>developer key prod</example>
        [global::Newtonsoft.Json.JsonProperty("label")]
        public string? Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminCreateDeveloperKeyRequest" /> class.
        /// </summary>
        /// <param name="label">
        /// API key label. The default value is `DeepL API Key`.<br/>
        /// Example: developer key prod
        /// </param>
        public AdminCreateDeveloperKeyRequest(
            string? label)
        {
            this.Label = label;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminCreateDeveloperKeyRequest" /> class.
        /// </summary>
        public AdminCreateDeveloperKeyRequest()
        {
        }
    }
}