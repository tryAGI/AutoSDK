//HintName: G.Models.InternalTemplateGroupCreateManagerConfigDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InternalTemplateGroupCreateManagerConfigDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerTypeJsonConverter))]
        public global::G.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType? ManagerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTemplateGroupCreateManagerConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="managerType"></param>
        public InternalTemplateGroupCreateManagerConfigDiscriminator(
            global::G.InternalTemplateGroupCreateManagerConfigDiscriminatorManagerType? managerType)
        {
            this.ManagerType = managerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTemplateGroupCreateManagerConfigDiscriminator" /> class.
        /// </summary>
        public InternalTemplateGroupCreateManagerConfigDiscriminator()
        {
        }
    }
}