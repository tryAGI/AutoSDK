//HintName: G.Models.SecretScanningListAlertsForEnterpriseDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// <br/>Default Value: desc
    /// </summary>
    public enum SecretScanningListAlertsForEnterpriseDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningListAlertsForEnterpriseDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListAlertsForEnterpriseDirection value)
        {
            return value switch
            {
                SecretScanningListAlertsForEnterpriseDirection.Asc => "asc",
                SecretScanningListAlertsForEnterpriseDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListAlertsForEnterpriseDirection ToEnum(string value)
        {
            return value switch
            {
                "asc" => SecretScanningListAlertsForEnterpriseDirection.Asc,
                "desc" => SecretScanningListAlertsForEnterpriseDirection.Desc,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}