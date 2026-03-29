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
        [global::System.Text.Json.Serialization.JsonPropertyName("manager_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GroupSchemaManagerConfigDiscriminatorManagerTypeJsonConverter))]
        public global::G.GroupSchemaManagerConfigDiscriminatorManagerType? ManagerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSchemaManagerConfigDiscriminator" /> class.
        /// </summary>
        /// <param name="managerType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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