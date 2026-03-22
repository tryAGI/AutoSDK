//HintName: G.Models.WebhookMemberAddedChangesPermissionTo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookMemberAddedChangesPermissionTo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="admin")]
        Admin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMemberAddedChangesPermissionToExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMemberAddedChangesPermissionTo value)
        {
            return value switch
            {
                WebhookMemberAddedChangesPermissionTo.Admin => "admin",
                WebhookMemberAddedChangesPermissionTo.Read => "read",
                WebhookMemberAddedChangesPermissionTo.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMemberAddedChangesPermissionTo? ToEnum(string value)
        {
            return value switch
            {
                "admin" => WebhookMemberAddedChangesPermissionTo.Admin,
                "read" => WebhookMemberAddedChangesPermissionTo.Read,
                "write" => WebhookMemberAddedChangesPermissionTo.Write,
                _ => null,
            };
        }
    }
}