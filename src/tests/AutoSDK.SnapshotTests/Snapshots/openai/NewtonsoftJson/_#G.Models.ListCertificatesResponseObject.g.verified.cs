//HintName: G.Models.ListCertificatesResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListCertificatesResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListCertificatesResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListCertificatesResponseObject value)
        {
            return value switch
            {
                ListCertificatesResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListCertificatesResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ListCertificatesResponseObject.List,
                _ => null,
            };
        }
    }
}