//HintName: G.Models.PrivilegeEntity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PrivilegeEntity
    {
        /// <summary>
        ///   The type of the object to which the privilege belongs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectType { get; set; } = default!;

        /// <summary>
        ///   The privilege that is granted to the role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privilege", Required = global::Newtonsoft.Json.Required.Always)]
        public string Privilege { get; set; } = default!;

        /// <summary>
        ///   The name of the object to which the role is granted the specified privilege.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectName { get; set; } = default!;

        /// <summary>
        ///   The name of the database in which this operation has been executed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("db_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DbName { get; set; } = default!;

        /// <summary>
        ///   The name of the user who granted a specific role to a user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("grantor")]
        public string? Grantor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivilegeEntity" /> class.
        /// </summary>
        /// <param name="objectType">
        ///   The type of the object to which the privilege belongs.
        /// </param>
        /// <param name="privilege">
        ///   The privilege that is granted to the role.
        /// </param>
        /// <param name="objectName">
        ///   The name of the object to which the role is granted the specified privilege.
        /// </param>
        /// <param name="dbName">
        ///   The name of the database in which this operation has been executed.
        /// </param>
        /// <param name="grantor">
        ///   The name of the user who granted a specific role to a user.
        /// </param>
        public PrivilegeEntity(
            string objectType,
            string privilege,
            string objectName,
            string dbName,
            string? grantor)
        {
            this.ObjectType = objectType ?? throw new global::System.ArgumentNullException(nameof(objectType));
            this.Privilege = privilege ?? throw new global::System.ArgumentNullException(nameof(privilege));
            this.ObjectName = objectName ?? throw new global::System.ArgumentNullException(nameof(objectName));
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.Grantor = grantor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PrivilegeEntity" /> class.
        /// </summary>
        public PrivilegeEntity()
        {
        }
    }
}