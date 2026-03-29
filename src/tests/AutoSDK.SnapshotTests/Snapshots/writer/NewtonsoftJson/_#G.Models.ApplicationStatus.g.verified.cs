//HintName: G.Models.ApplicationStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Current deployment status of the application. Note: currently only `deployed` applications are returned.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ApplicationStatus
    {
        /// <summary>
        /// currently only `deployed` applications are returned.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deployed")]
        Deployed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="draft")]
        Draft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ApplicationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApplicationStatus value)
        {
            return value switch
            {
                ApplicationStatus.Deployed => "deployed",
                ApplicationStatus.Draft => "draft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApplicationStatus? ToEnum(string value)
        {
            return value switch
            {
                "deployed" => ApplicationStatus.Deployed,
                "draft" => ApplicationStatus.Draft,
                _ => null,
            };
        }
    }
}