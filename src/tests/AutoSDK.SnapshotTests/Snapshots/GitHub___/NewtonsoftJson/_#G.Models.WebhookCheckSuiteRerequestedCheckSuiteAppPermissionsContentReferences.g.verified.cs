//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentReferences.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentReferences
    {
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
    public static class WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentReferencesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentReferences value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentReferences.Read => "read",
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentReferences.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentReferences? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentReferences.Read,
                "write" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsContentReferences.Write,
                _ => null,
            };
        }
    }
}