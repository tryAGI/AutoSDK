//HintName: G.Models.DeveloperMessageRole.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the role of the message author<br/>
    /// Default Value: developer
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeveloperMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="developer")]
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeveloperMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeveloperMessageRole value)
        {
            return value switch
            {
                DeveloperMessageRole.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeveloperMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "developer" => DeveloperMessageRole.Developer,
                _ => null,
            };
        }
    }
}