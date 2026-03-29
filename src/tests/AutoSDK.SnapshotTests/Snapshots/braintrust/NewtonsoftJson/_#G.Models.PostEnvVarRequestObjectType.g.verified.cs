//HintName: G.Models.PostEnvVarRequestObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the object the environment variable is scoped for
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostEnvVarRequestObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostEnvVarRequestObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostEnvVarRequestObjectType value)
        {
            return value switch
            {
                PostEnvVarRequestObjectType.Function => "function",
                PostEnvVarRequestObjectType.Organization => "organization",
                PostEnvVarRequestObjectType.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostEnvVarRequestObjectType? ToEnum(string value)
        {
            return value switch
            {
                "function" => PostEnvVarRequestObjectType.Function,
                "organization" => PostEnvVarRequestObjectType.Organization,
                "project" => PostEnvVarRequestObjectType.Project,
                _ => null,
            };
        }
    }
}