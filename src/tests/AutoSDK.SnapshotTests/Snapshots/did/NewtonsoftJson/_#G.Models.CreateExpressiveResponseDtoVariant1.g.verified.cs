//HintName: G.Models.CreateExpressiveResponseDtoVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// From T, pick a set of properties whose keys are in the union K
    /// </summary>
    public sealed partial class CreateExpressiveResponseDtoVariant1
    {
        /// <summary>
        /// The id of the expressive video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CreateExpressiveResponseDtoVariant1StatusJsonConverter))]
        public global::G.CreateExpressiveResponseDtoVariant1Status Status { get; set; } = default!;

        /// <summary>
        /// The date the video was created<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </summary>
        /// <example>2021-01-01T00:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressiveResponseDtoVariant1" /> class.
        /// </summary>
        /// <param name="id">
        /// The id of the expressive video
        /// </param>
        /// <param name="status"></param>
        /// <param name="createdAt">
        /// The date the video was created<br/>
        /// Example: 2021-01-01T00:00:00.000Z
        /// </param>
        public CreateExpressiveResponseDtoVariant1(
            string id,
            global::G.CreateExpressiveResponseDtoVariant1Status status,
            string createdAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExpressiveResponseDtoVariant1" /> class.
        /// </summary>
        public CreateExpressiveResponseDtoVariant1()
        {
        }
    }
}