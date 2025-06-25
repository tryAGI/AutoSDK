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
    public enum CatalogRunAction
    {
        /// <summary>
        /// Create catalog.
        /// </summary>
        CREATE,
        /// <summary>
        /// Update catalog.
        /// </summary>
        UPDATE,
        /// <summary>
        /// Delete catalog.
        /// </summary>
        DELETE,
        /// <summary>
        /// Upload catalog file.
        /// </summary>
        CREATEFILE,
        /// <summary>
        /// Process catalog file.
        /// </summary>
        PROCESSFILE,
        /// <summary>
        /// Delete catalog file.
        /// </summary>
        DELETEFILE,
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
                CatalogRunAction.CREATE => "CATALOG_RUN_ACTION_CREATE",
                CatalogRunAction.UPDATE => "CATALOG_RUN_ACTION_UPDATE",
                CatalogRunAction.DELETE => "CATALOG_RUN_ACTION_DELETE",
                CatalogRunAction.CREATEFILE => "CATALOG_RUN_ACTION_CREATE_FILE",
                CatalogRunAction.PROCESSFILE => "CATALOG_RUN_ACTION_PROCESS_FILE",
                CatalogRunAction.DELETEFILE => "CATALOG_RUN_ACTION_DELETE_FILE",
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
                "CATALOG_RUN_ACTION_CREATE" => CatalogRunAction.CREATE,
                "CATALOG_RUN_ACTION_UPDATE" => CatalogRunAction.UPDATE,
                "CATALOG_RUN_ACTION_DELETE" => CatalogRunAction.DELETE,
                "CATALOG_RUN_ACTION_CREATE_FILE" => CatalogRunAction.CREATEFILE,
                "CATALOG_RUN_ACTION_PROCESS_FILE" => CatalogRunAction.PROCESSFILE,
                "CATALOG_RUN_ACTION_DELETE_FILE" => CatalogRunAction.DELETEFILE,
                _ => null,
            };
        }
    }
}