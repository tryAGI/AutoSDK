//HintName: G.Models.PutEnvVarRequestObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the object the environment variable is scoped for
    /// </summary>
    public enum PutEnvVarRequestObjectType
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
    public static class PutEnvVarRequestObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PutEnvVarRequestObjectType value)
        {
            return value switch
            {
                PutEnvVarRequestObjectType.Function => "function",
                PutEnvVarRequestObjectType.Organization => "organization",
                PutEnvVarRequestObjectType.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PutEnvVarRequestObjectType? ToEnum(string value)
        {
            return value switch
            {
                "function" => PutEnvVarRequestObjectType.Function,
                "organization" => PutEnvVarRequestObjectType.Organization,
                "project" => PutEnvVarRequestObjectType.Project,
                _ => null,
            };
        }
    }
}