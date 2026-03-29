//HintName: G.Models.CreateAPIKeyResponseVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateAPIKeyResponseVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hashedKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string HashedKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("apiKey", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKey { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAPIKeyResponseVariant1" /> class.
        /// </summary>
        /// <param name="hashedKey"></param>
        /// <param name="apiKey"></param>
        /// <param name="id"></param>
        public CreateAPIKeyResponseVariant1(
            string hashedKey,
            string apiKey,
            string id)
        {
            this.HashedKey = hashedKey ?? throw new global::System.ArgumentNullException(nameof(hashedKey));
            this.ApiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAPIKeyResponseVariant1" /> class.
        /// </summary>
        public CreateAPIKeyResponseVariant1()
        {
        }
    }
}