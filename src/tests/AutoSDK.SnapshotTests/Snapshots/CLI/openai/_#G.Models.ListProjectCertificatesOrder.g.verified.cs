//HintName: G.Models.ListProjectCertificatesOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum ListProjectCertificatesOrder
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
    public static class ListProjectCertificatesOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListProjectCertificatesOrder value)
        {
            return value switch
            {
                ListProjectCertificatesOrder.Asc => "asc",
                ListProjectCertificatesOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListProjectCertificatesOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListProjectCertificatesOrder.Asc,
                "desc" => ListProjectCertificatesOrder.Desc,
                _ => null,
            };
        }
    }
}