//HintName: G.Models.WorkspaceDefaultsObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkspaceDefaultsObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workspace")]
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceDefaultsObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceDefaultsObject value)
        {
            return value switch
            {
                WorkspaceDefaultsObject.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceDefaultsObject? ToEnum(string value)
        {
            return value switch
            {
                "workspace" => WorkspaceDefaultsObject.Workspace,
                _ => null,
            };
        }
    }
}