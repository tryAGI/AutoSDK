//HintName: G.Models.PostCliCreateSessionRequestScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Key scope. 'project' (default) returns a project-level API key; 'user' returns a user-level API key valid across projects.<br/>
    /// Default Value: project
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostCliCreateSessionRequestScope
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
    public static class PostCliCreateSessionRequestScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostCliCreateSessionRequestScope value)
        {
            return value switch
            {
                PostCliCreateSessionRequestScope.Project => "project",
                PostCliCreateSessionRequestScope.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostCliCreateSessionRequestScope? ToEnum(string value)
        {
            return value switch
            {
                "project" => PostCliCreateSessionRequestScope.Project,
                "user" => PostCliCreateSessionRequestScope.User,
                _ => null,
            };
        }
    }
}