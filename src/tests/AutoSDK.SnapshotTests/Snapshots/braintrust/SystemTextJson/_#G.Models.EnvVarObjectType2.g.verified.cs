//HintName: G.Models.EnvVarObjectType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the object the environment variable is scoped for
    /// </summary>
    public enum EnvVarObjectType2
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
    public static class EnvVarObjectType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvVarObjectType2 value)
        {
            return value switch
            {
                EnvVarObjectType2.Function => "function",
                EnvVarObjectType2.Organization => "organization",
                EnvVarObjectType2.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvVarObjectType2? ToEnum(string value)
        {
            return value switch
            {
                "function" => EnvVarObjectType2.Function,
                "organization" => EnvVarObjectType2.Organization,
                "project" => EnvVarObjectType2.Project,
                _ => null,
            };
        }
    }
}