//HintName: G.Models.PostToolkitsMultiRequestManagedBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Entity responsible for managing the toolkits
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostToolkitsMultiRequestManagedBy
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="composio")]
        Composio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="project")]
        Project,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostToolkitsMultiRequestManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostToolkitsMultiRequestManagedBy value)
        {
            return value switch
            {
                PostToolkitsMultiRequestManagedBy.All => "all",
                PostToolkitsMultiRequestManagedBy.Composio => "composio",
                PostToolkitsMultiRequestManagedBy.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostToolkitsMultiRequestManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "all" => PostToolkitsMultiRequestManagedBy.All,
                "composio" => PostToolkitsMultiRequestManagedBy.Composio,
                "project" => PostToolkitsMultiRequestManagedBy.Project,
                _ => null,
            };
        }
    }
}