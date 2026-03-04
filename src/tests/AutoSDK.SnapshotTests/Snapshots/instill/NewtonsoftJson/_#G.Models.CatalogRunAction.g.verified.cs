//HintName: G.Models.CatalogRunAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// CatalogRunAction describes the actions a user has over a catalog.<br/>
    ///  - CATALOG_RUN_ACTION_CREATE: Create catalog.<br/>
    ///  - CATALOG_RUN_ACTION_UPDATE: Update catalog.<br/>
    ///  - CATALOG_RUN_ACTION_DELETE: Delete catalog.<br/>
    ///  - CATALOG_RUN_ACTION_CREATE_FILE: Upload catalog file.<br/>
    ///  - CATALOG_RUN_ACTION_PROCESS_FILE: Process catalog file.<br/>
    ///  - CATALOG_RUN_ACTION_DELETE_FILE: Delete catalog file.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CatalogRunAction
    {
        /// <summary>
        /// Create catalog.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CATALOG_RUN_ACTION_CREATE")]
        Create,
        /// <summary>
        /// Update catalog.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CATALOG_RUN_ACTION_UPDATE")]
        Update,
        /// <summary>
        /// Delete catalog.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CATALOG_RUN_ACTION_DELETE")]
        Delete,
        /// <summary>
        /// Upload catalog file.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CATALOG_RUN_ACTION_CREATE_FILE")]
        CreateFile,
        /// <summary>
        /// Process catalog file.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CATALOG_RUN_ACTION_PROCESS_FILE")]
        ProcessFile,
        /// <summary>
        /// Delete catalog file.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CATALOG_RUN_ACTION_DELETE_FILE")]
        DeleteFile,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CatalogRunActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CatalogRunAction value)
        {
            return value switch
            {
                CatalogRunAction.Create => "CATALOG_RUN_ACTION_CREATE",
                CatalogRunAction.Update => "CATALOG_RUN_ACTION_UPDATE",
                CatalogRunAction.Delete => "CATALOG_RUN_ACTION_DELETE",
                CatalogRunAction.CreateFile => "CATALOG_RUN_ACTION_CREATE_FILE",
                CatalogRunAction.ProcessFile => "CATALOG_RUN_ACTION_PROCESS_FILE",
                CatalogRunAction.DeleteFile => "CATALOG_RUN_ACTION_DELETE_FILE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CatalogRunAction? ToEnum(string value)
        {
            return value switch
            {
                "CATALOG_RUN_ACTION_CREATE" => CatalogRunAction.Create,
                "CATALOG_RUN_ACTION_UPDATE" => CatalogRunAction.Update,
                "CATALOG_RUN_ACTION_DELETE" => CatalogRunAction.Delete,
                "CATALOG_RUN_ACTION_CREATE_FILE" => CatalogRunAction.CreateFile,
                "CATALOG_RUN_ACTION_PROCESS_FILE" => CatalogRunAction.ProcessFile,
                "CATALOG_RUN_ACTION_DELETE_FILE" => CatalogRunAction.DeleteFile,
                _ => null,
            };
        }
    }
}