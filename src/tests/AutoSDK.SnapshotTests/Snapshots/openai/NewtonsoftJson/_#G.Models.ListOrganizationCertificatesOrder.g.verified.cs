//HintName: G.Models.ListOrganizationCertificatesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListOrganizationCertificatesOrder
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
    public static class ListOrganizationCertificatesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListOrganizationCertificatesOrder value)
        {
            return value switch
            {
                ListOrganizationCertificatesOrder.Asc => "asc",
                ListOrganizationCertificatesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListOrganizationCertificatesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListOrganizationCertificatesOrder.Asc,
                "desc" => ListOrganizationCertificatesOrder.Desc,
                _ => null,
            };
        }
    }
}