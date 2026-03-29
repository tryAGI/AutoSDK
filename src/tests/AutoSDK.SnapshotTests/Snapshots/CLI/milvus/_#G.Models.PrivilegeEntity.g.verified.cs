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
        [global::System.Text.Json.Serialization.JsonPropertyName("object_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectType { get; set; }

        /// <summary>
        ///   The privilege that is granted to the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privilege")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Privilege { get; set; }

        /// <summary>
        ///   The name of the object to which the role is granted the specified privilege.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectName { get; set; }

        /// <summary>
        ///   The name of the database in which this operation has been executed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbName { get; set; }

        /// <summary>
        ///   The name of the user who granted a specific role to a user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grantor")]
        public string? Grantor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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