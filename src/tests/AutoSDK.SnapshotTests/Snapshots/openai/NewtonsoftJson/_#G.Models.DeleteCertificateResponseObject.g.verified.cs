//HintName: G.Models.DeleteCertificateResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, must be `certificate.deleted`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteCertificateResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="certificate.deleted")]
        CertificateDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeleteCertificateResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteCertificateResponseObject value)
        {
            return value switch
            {
                DeleteCertificateResponseObject.CertificateDeleted => "certificate.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteCertificateResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "certificate.deleted" => DeleteCertificateResponseObject.CertificateDeleted,
                _ => null,
            };
        }
    }
}