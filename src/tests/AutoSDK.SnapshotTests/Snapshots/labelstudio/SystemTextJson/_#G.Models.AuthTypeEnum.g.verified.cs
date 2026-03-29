//HintName: G.Models.AuthTypeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `pat` - Personal Access Token<br/>
    /// * `dbx_sp` - Databricks Service Principal<br/>
    /// * `azure_ad_sp` - Azure AD Service Principal
    /// </summary>
    public enum AuthTypeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        AzureAdSp,
        /// <summary>
        /// 
        /// </summary>
        DbxSp,
        /// <summary>
        /// 
        /// </summary>
        Pat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthTypeEnum value)
        {
            return value switch
            {
                AuthTypeEnum.AzureAdSp => "azure_ad_sp",
                AuthTypeEnum.DbxSp => "dbx_sp",
                AuthTypeEnum.Pat => "pat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "azure_ad_sp" => AuthTypeEnum.AzureAdSp,
                "dbx_sp" => AuthTypeEnum.DbxSp,
                "pat" => AuthTypeEnum.Pat,
                _ => null,
            };
        }
    }
}