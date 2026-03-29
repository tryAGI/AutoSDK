//HintName: G.Models.Target.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Target (what was acted upon) information.
    /// </summary>
    public sealed partial class Target
    {
        /// <summary>
        /// Types of entities that can be acted upon.<br/>
        /// WORKSPACE: A workspace entity<br/>
        /// VIDEO: A video entity<br/>
        /// USER: A user entity (can be same as Actor in self-service actions like login/profile updates)<br/>
        /// ORGANIZATION: An organization entity<br/>
        /// ASSET: An asset entity (avatars, images, etc.)<br/>
        /// LEARNER_GROUP: An LMS learner group (cohort) entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TargetTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TargetType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Target" /> class.
        /// </summary>
        /// <param name="type">
        /// Types of entities that can be acted upon.<br/>
        /// WORKSPACE: A workspace entity<br/>
        /// VIDEO: A video entity<br/>
        /// USER: A user entity (can be same as Actor in self-service actions like login/profile updates)<br/>
        /// ORGANIZATION: An organization entity<br/>
        /// ASSET: An asset entity (avatars, images, etc.)<br/>
        /// LEARNER_GROUP: An LMS learner group (cohort) entity
        /// </param>
        /// <param name="id"></param>
        /// <param name="name">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Target(
            global::G.TargetType type,
            string id,
            string? name)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Target" /> class.
        /// </summary>
        public Target()
        {
        }
    }
}