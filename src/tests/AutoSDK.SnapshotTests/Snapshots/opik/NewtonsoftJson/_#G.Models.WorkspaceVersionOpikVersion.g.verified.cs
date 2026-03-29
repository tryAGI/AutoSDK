//HintName: G.Models.WorkspaceVersionOpikVersion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The determined Opik navigation version for this workspace.<br/>
    /// 'version_1' = legacy workspace-scoped navigation,<br/>
    /// 'version_2' = new project-first navigation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WorkspaceVersionOpikVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="version_1")]
        Version1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="version_2")]
        Version2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceVersionOpikVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceVersionOpikVersion value)
        {
            return value switch
            {
                WorkspaceVersionOpikVersion.Version1 => "version_1",
                WorkspaceVersionOpikVersion.Version2 => "version_2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceVersionOpikVersion? ToEnum(string value)
        {
            return value switch
            {
                "version_1" => WorkspaceVersionOpikVersion.Version1,
                "version_2" => WorkspaceVersionOpikVersion.Version2,
                _ => null,
            };
        }
    }
}