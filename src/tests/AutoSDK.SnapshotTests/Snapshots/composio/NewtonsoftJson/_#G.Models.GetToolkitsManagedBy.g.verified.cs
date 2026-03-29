//HintName: G.Models.GetToolkitsManagedBy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Entity responsible for managing the toolkits
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetToolkitsManagedBy
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
    public static class GetToolkitsManagedByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetToolkitsManagedBy value)
        {
            return value switch
            {
                GetToolkitsManagedBy.All => "all",
                GetToolkitsManagedBy.Composio => "composio",
                GetToolkitsManagedBy.Project => "project",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetToolkitsManagedBy? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetToolkitsManagedBy.All,
                "composio" => GetToolkitsManagedBy.Composio,
                "project" => GetToolkitsManagedBy.Project,
                _ => null,
            };
        }
    }
}