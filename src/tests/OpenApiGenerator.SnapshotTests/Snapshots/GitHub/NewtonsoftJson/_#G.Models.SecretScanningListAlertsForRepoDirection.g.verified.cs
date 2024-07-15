//HintName: G.Models.SecretScanningListAlertsForRepoDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SecretScanningListAlertsForRepoDirection
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="asc")]
        Asc,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="desc")]
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningListAlertsForRepoDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListAlertsForRepoDirection value)
        {
            return value switch
            {
                SecretScanningListAlertsForRepoDirection.Asc => "asc",
                SecretScanningListAlertsForRepoDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListAlertsForRepoDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SecretScanningListAlertsForRepoDirection.Asc,
                "desc" => SecretScanningListAlertsForRepoDirection.Desc,
                _ => null,
            };
        }
    }
}