//HintName: G.Models.GroupUpdateManagerConfigVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupUpdateManagerConfigVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manager_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeJsonConverter))]
        public global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType? ManagerType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUpdateManagerConfigVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="managerType"></param>
        public GroupUpdateManagerConfigVariant1Discriminator(
            global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType? managerType)
        {
            this.ManagerType = managerType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupUpdateManagerConfigVariant1Discriminator" /> class.
        /// </summary>
        public GroupUpdateManagerConfigVariant1Discriminator()
        {
        }
    }
}