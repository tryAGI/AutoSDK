//HintName: G.Models.GroupSchemaManagerConfigDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupSchemaManagerConfigDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        public global::G.GroupSchemaManagerConfigDiscriminatorManagerType? ManagerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSchemaManagerConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="managerType"></param>
        public GroupSchemaManagerConfigDiscriminator(
            global::G.GroupSchemaManagerConfigDiscriminatorManagerType? managerType)
        {
            this.ManagerType = managerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSchemaManagerConfigDiscriminator" /> class.
        /// </summary>
        public GroupSchemaManagerConfigDiscriminator()
        {
        }
    }
}