//HintName: G.Models.GetCliGetSessionResponseScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The key scope for this session<br/>
    /// Example: project
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetCliGetSessionResponseScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="user")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetCliGetSessionResponseScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetCliGetSessionResponseScope value)
        {
            return value switch
            {
                GetCliGetSessionResponseScope.Project => "project",
                GetCliGetSessionResponseScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetCliGetSessionResponseScope? ToEnum(string value)
        {
            return value switch
            {
                "project" => GetCliGetSessionResponseScope.Project,
                "user" => GetCliGetSessionResponseScope.User,
                _ => null,
            };
        }
    }
}