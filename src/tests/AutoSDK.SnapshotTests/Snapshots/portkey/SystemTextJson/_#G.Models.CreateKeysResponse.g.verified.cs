//HintName: G.Models.CreateKeysResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateKeysResponse
    {
        /// <summary>
        /// Example: 183f497a-2a7f-4f47-992e-26213fa863we
        /// </summary>
        /// <example>183f497a-2a7f-4f47-992e-26213fa863we</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Example: abssofjosfjs
        /// </summary>
        /// <example>abssofjosfjs</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// Example: api-key
        /// </summary>
        /// <example>api-key</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateKeysResponseObjectJsonConverter))]
        public global::G.CreateKeysResponseObject? Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeysResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Example: 183f497a-2a7f-4f47-992e-26213fa863we
        /// </param>
        /// <param name="key">
        /// Example: abssofjosfjs
        /// </param>
        /// <param name="object">
        /// Example: api-key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateKeysResponse(
            global::System.Guid? id,
            string? key,
            global::G.CreateKeysResponseObject? @object)
        {
            this.Id = id;
            this.Key = key;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateKeysResponse" /> class.
        /// </summary>
        public CreateKeysResponse()
        {
        }
    }
}