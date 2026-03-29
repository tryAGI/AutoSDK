//HintName: G.Models.PostCliCreateSessionResponseScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The key scope for this session<br/>
    /// Example: project
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostCliCreateSessionResponseScope
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
    public static class PostCliCreateSessionResponseScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostCliCreateSessionResponseScope value)
        {
            return value switch
            {
                PostCliCreateSessionResponseScope.Project => "project",
                PostCliCreateSessionResponseScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostCliCreateSessionResponseScope? ToEnum(string value)
        {
            return value switch
            {
                "project" => PostCliCreateSessionResponseScope.Project,
                "user" => PostCliCreateSessionResponseScope.User,
                _ => null,
            };
        }
    }
}