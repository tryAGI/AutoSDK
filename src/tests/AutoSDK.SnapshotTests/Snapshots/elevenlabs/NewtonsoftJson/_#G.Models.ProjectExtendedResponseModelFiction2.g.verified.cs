//HintName: G.Models.ProjectExtendedResponseModelFiction2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProjectExtendedResponseModelFiction2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fiction")]
        Fiction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="non-fiction")]
        NonFiction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectExtendedResponseModelFiction2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectExtendedResponseModelFiction2 value)
        {
            return value switch
            {
                ProjectExtendedResponseModelFiction2.Fiction => "fiction",
                ProjectExtendedResponseModelFiction2.NonFiction => "non-fiction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectExtendedResponseModelFiction2? ToEnum(string value)
        {
            return value switch
            {
                "fiction" => ProjectExtendedResponseModelFiction2.Fiction,
                "non-fiction" => ProjectExtendedResponseModelFiction2.NonFiction,
                _ => null,
            };
        }
    }
}