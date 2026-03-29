//HintName: G.Models.GetMigrationGetNanoidType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: CONNECTED_ACCOUNT
    /// </summary>
    public enum GetMigrationGetNanoidType
    {
        /// <summary>
        /// 
        /// </summary>
        AuthConfig,
        /// <summary>
        /// 
        /// </summary>
        ConnectedAccount,
        /// <summary>
        /// 
        /// </summary>
        TriggerInstance,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetMigrationGetNanoidTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetMigrationGetNanoidType value)
        {
            return value switch
            {
                GetMigrationGetNanoidType.AuthConfig => "AUTH_CONFIG",
                GetMigrationGetNanoidType.ConnectedAccount => "CONNECTED_ACCOUNT",
                GetMigrationGetNanoidType.TriggerInstance => "TRIGGER_INSTANCE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetMigrationGetNanoidType? ToEnum(string value)
        {
            return value switch
            {
                "AUTH_CONFIG" => GetMigrationGetNanoidType.AuthConfig,
                "CONNECTED_ACCOUNT" => GetMigrationGetNanoidType.ConnectedAccount,
                "TRIGGER_INSTANCE" => GetMigrationGetNanoidType.TriggerInstance,
                _ => null,
            };
        }
    }
}