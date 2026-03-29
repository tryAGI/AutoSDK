//HintName: G.Models.ListWorkspaceScope.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListWorkspaceScope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="joined")]
        Joined,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListWorkspaceScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListWorkspaceScope value)
        {
            return value switch
            {
                ListWorkspaceScope.All => "all",
                ListWorkspaceScope.Joined => "joined",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListWorkspaceScope? ToEnum(string value)
        {
            return value switch
            {
                "all" => ListWorkspaceScope.All,
                "joined" => ListWorkspaceScope.Joined,
                _ => null,
            };
        }
    }
}