//HintName: G.Models.ApiKeysDeleteKeysResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKeysDeleteKeysResponse200
    {
        /// <summary>
        /// Confirmation that the API key was deleted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysDeleteKeysResponse200" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Confirmation that the API key was deleted
        /// </param>
        public ApiKeysDeleteKeysResponse200(
            bool deleted)
        {
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysDeleteKeysResponse200" /> class.
        /// </summary>
        public ApiKeysDeleteKeysResponse200()
        {
        }
    }
}