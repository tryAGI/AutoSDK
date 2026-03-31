//HintName: G.Models.EnvVarObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the object the environment variable is scoped for
    /// </summary>
    public enum EnvVarObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvVarObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvVarObjectType value)
        {
            return value switch
            {
                EnvVarObjectType.Function => "function",
                EnvVarObjectType.Organization => "organization",
                EnvVarObjectType.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvVarObjectType? ToEnum(string value)
        {
            return value switch
            {
                "function" => EnvVarObjectType.Function,
                "organization" => EnvVarObjectType.Organization,
                "project" => EnvVarObjectType.Project,
                _ => null,
            };
        }
    }
}