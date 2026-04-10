//HintName: G.Models.GroupCreateManagerConfigDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupCreateManagerConfigDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GroupCreateManagerConfigDiscriminatorManagerTypeJsonConverter))]
        public global::G.GroupCreateManagerConfigDiscriminatorManagerType? ManagerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupCreateManagerConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="managerType"></param>
        public GroupCreateManagerConfigDiscriminator(
            global::G.GroupCreateManagerConfigDiscriminatorManagerType? managerType)
        {
            this.ManagerType = managerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupCreateManagerConfigDiscriminator" /> class.
        /// </summary>
        public GroupCreateManagerConfigDiscriminator()
        {
        }
    }
}